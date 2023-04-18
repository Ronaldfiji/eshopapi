using AutoMapper;
using DataModel.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository;
using SchoolApiv2.Repository.Contracts;
using SharedModel.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolApiv2.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IPrerequisiteRepository prerequisiteRepository;
        private readonly IEnrollmentRepository enrollmentRepository;
        private readonly IUserRepository userRepository;
        private readonly IScoreRepository scoreRepository;
        private ILogger<EnrollmentController> logger;


        public EnrollmentController(IEnrollmentRepository _enrollmentRepository, ILogger<EnrollmentController> _logger,
            IScoreRepository _scoreRepository, IPrerequisiteRepository _prerequisiteRepository, IUserRepository _userRepository)
        {
            enrollmentRepository = _enrollmentRepository;
            logger = _logger;
            scoreRepository = _scoreRepository;
            prerequisiteRepository = _prerequisiteRepository;
            userRepository = _userRepository;
        }

        // GET api/<EnrollmentController>GetEnrollment/5
        [HttpGet("GetEnrollment/{id:int}")]
        public async Task<ActionResult<EnrollmentDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var enrollment = await enrollmentRepository.Get(id);

                if (enrollment == null)
                {
                    return NotFound();
                }

                var enrollmentDTO = enrollment.ConvertToDto();
                return Ok(enrollmentDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

   

        // GET: api/<EnrollmentController/GetEnrollments>
        [HttpGet("GetEnrollments")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                var pagedEnrollment = await this.enrollmentRepository.GetAllEnrollment(pagingRequestDto);

                if (pagedEnrollment == null)
                {
                    return NotFound();
                }
                var enrollmentDtos = pagedEnrollment.ConvertToDto();

                var pagedResponse = new PagingResponse<EnrollmentDto>
                {
                    Items = enrollmentDtos.ToList(),
                    MetaData = pagedEnrollment.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // GET: EnrollmentController/GetByDate?from=xx/xx/xxxx&to=xx/xx/xxxxx
        //[HttpGet("GetBydate/{from}/{to}")]
        [HttpGet("GetBydate")]
        public async Task<ActionResult<EnrollmentDto>> GetByDate(DateTime from  , DateTime to)
        {
            var httpResponse = new HttpResponseMessage();
           
            if(DateTime.MinValue == from)
            {
                from = DateTime.UtcNow.AddHours(12);
            }
            if (DateTime.MinValue == to)
            {
                to = DateTime.UtcNow.AddDays(7).AddHours(12);
            }

            if (from > to)
            {
                return BadRequest("Invalid date range provided ! Provide valid date range");
            }           
            
            try
            {
                var enrollments = await this.enrollmentRepository.GetEnrollmentByDate(from, to);
                if (enrollments == null)
                {
                    return NotFound();
                }
                var enrollmentDtos = enrollments.ConvertToDto();
                return Ok(enrollmentDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
       
        // POST: api/<EnrollmentController/Create>        
        [HttpPost("Create")]
        public async Task<ActionResult<EnrollmentDto>> PostItem([FromBody] EnrollmentToEditDto enrollmentToEditDto)
        {
            try
            {
                if (enrollmentToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(EnrollmentToEditDto)} cannot be null or empty !");
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    enrollmentToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }
                
                var prerequisite = await prerequisiteRepository.GetByCourse( enrollmentToEditDto.CourseId);
               
                if (prerequisite != null)
                {
                    var userCourses = await userRepository.GetUserCourse(enrollmentToEditDto.UserId);

                    if (userCourses != null)
                    {
                        var IsPrerequisiteOk = userCourses.Enrollments.Any(e => e.CourseId == prerequisite.PrerequisiteCourseId
                         && e.Passed == true  && e.DateCompleted != null );                      

                        if (IsPrerequisiteOk == false)
                        {
                            return BadRequest("Failed to meet course pre-requisite !");
                        }
                    }
                }
                var newEnrollment = await this.enrollmentRepository.CreateEnrollment(enrollmentToEditDto);

                if (newEnrollment == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newEnrollment?.ID})");
                }

                var newEnrollmentDto = newEnrollment.ConvertToDto();
                
               return CreatedAtAction(nameof(GetItem), new { id = newEnrollment.ID }, newEnrollmentDto);
            }
            catch (Exception ex)
            {  
                if (ex.Message.Contains("duplicate key row in object"))
                {                    
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
              

        //PATCH: api/EnrollmenController/UpdateEnrollment{int id, EnrollmentToEditDto}           
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdateEnrollment(int id, [FromBody] EnrollmentToEditDto enrollmentToEditDto)
        {
            try
            {
                if (enrollmentToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(EnrollmentToEditDto)} cannot be null or empty !");
                }

                if (id != enrollmentToEditDto.Id)
                    return BadRequest("Enrollment ID mismatch !");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    enrollmentToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                enrollmentToEditDto.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedEnrollment = await this.enrollmentRepository.UpdateEnrollment(enrollmentToEditDto);

                if (updatedEnrollment == null)
                {
                    return NotFound();
                }
                var enroll = await enrollmentRepository.Get(id);
               
                var enrollDto = enroll.ConvertToDto();
                return Ok(enrollDto);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key row in object"))
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        // DELETE api/<EnrollmentController>/Delete/5     
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<EnrollmentDto>> DeleteItem(int id)
        {
            try
            {
                var deletedItem = await enrollmentRepository.DeleteEnrollment(id);

                if (deletedItem == null)
                {
                    return NotFound($"Failed to delete object {nameof(EnrollmentDto)} with id : {id}");
                }             
                var deletedItemDto = deletedItem.ConvertToDto();
                
                return Ok(deletedItemDto); // or ' return NoContent();'

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}


//var model = JsonSerializer.Serialize(enrollmentDTO, new JsonSerializerOptions
//{
//    WriteIndented = true,
//    ReferenceHandler = ReferenceHandler.IgnoreCycles
//});
//Console.WriteLine("Json data is : " + model);