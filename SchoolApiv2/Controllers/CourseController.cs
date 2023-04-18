using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository;
using SchoolApiv2.Repository.Contracts;
using SharedModel.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolApiv2.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly ICourseRepository courseRepository;
        private ILogger<CourseController> logger;       

        public CourseController(ICourseRepository _courseRepository, ILogger<CourseController> _logger)
        {
            courseRepository = _courseRepository;           
            logger = _logger;
        }


        // GET api/<CourseController>GetCourse/5
        [HttpGet("GetCourse/{id:int}")]
        public async Task<ActionResult<CourseDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var course = await this.courseRepository.Get(id);

                if (course == null)
                {
                    return NotFound();
                }

                var courseDTO = course.ConvertToDto();

                return Ok(courseDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<CourseController/GetCourses>
        [HttpGet("GetCourses")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {

            try
            {
                var pagedCourses = await this.courseRepository.GetAllCourse(pagingRequestDto);

                if (pagedCourses == null)
                {
                    return NotFound();
                }

                var coursesDtos = pagedCourses.ConvertToDto();

                var pagedResponse = new PagingResponse<CourseDto>
                {
                    Items = coursesDtos.ToList(),
                    MetaData = pagedCourses.MetaData,
                };
                return Ok(pagedResponse);


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // GET: CourseController/Details/Y9COMM
        [HttpGet("Get/{code}")]
        public async Task<ActionResult<CourseDto>> GetByCode(string code)
        {

            var httpResponse = new HttpResponseMessage();

            try
            {
                var course = await this.courseRepository.GetByCode(code);
                if (course == null)
                {
                    return NotFound();
                }

                var corseDto = course.ConvertToDto();
                return Ok(corseDto);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<CourseController/Create>        
        [HttpPost("Create")]
        public async Task<ActionResult<CourseDto>> PostItem([FromBody] CourseToEditDto courseToEditDto)
        {
            try
            {
                if (courseToEditDto == null || !ModelState.IsValid || courseToEditDto.SchoolYearId < 1)
                {
                    return BadRequest($"{nameof(courseToEditDto)} cannot be null or empty !");
                }
                
                
                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    courseToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var course = await this.courseRepository.GetByCode(courseToEditDto.Code);
                if (course != null)
                {
                    ModelState.AddModelError("Course", $"Course with code {courseToEditDto.Code} exist in database !");
                    return BadRequest(ModelState);
                }


                var newCourse = await this.courseRepository.CreateCourse(courseToEditDto);

                if (newCourse == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newCourse?.ID})");
                }

                var newCourseDto = newCourse.ConvertToDto();
                return CreatedAtAction(nameof(GetItem), new { id = newCourse.ID }, newCourseDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //PATCH: CourseController/UpdateUser{int id, UserToUpdateDto}           
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdateCourse(int id, [FromBody] CourseToEditDto courseToEditDto)
        {
            try
            {
                if (courseToEditDto == null || !ModelState.IsValid || courseToEditDto.SchoolYearId < 1)
                {
                    return BadRequest($"{nameof(UserToEditDto)} cannot be null or empty !");
                }

                if (id != courseToEditDto.Id)
                    return BadRequest("Course ID mismatch");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    courseToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                courseToEditDto.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedCourse = await this.courseRepository.UpdateCourse(id, courseToEditDto);

                if (updatedCourse == null)
                {
                    return NotFound();
                }
                var course = await courseRepository.Get(id);
                var courseDto = course.ConvertToDto();
                return Ok(courseDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        // Delete: CourseController/Delete/5
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<UserDto>> DeleteItem(int id)
        {
            try
            {
                var deletedCourse = await courseRepository.DeleteCourse(id);

                if (deletedCourse == null)
                {
                    return NotFound();
                }
                var courseDto = deletedCourse.ConvertToDto();
                //var userMapper = mapper.Map<UserDto>(deletedUser);

                return Ok(courseDto); // or ' return NoContent();'

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // Delete: CourseController/Delete/List<courses>
        [HttpPost ("DeleteItems")]
        public async Task<ActionResult> DeleteCourses([FromBody] IEnumerable<CourseToEditDto> courseDtos)
        {
            try
            {

                if (courseDtos == null || !courseDtos.Any() || !ModelState.IsValid)
                {
                    return BadRequest($"Entity to delete {nameof(courseDtos)} cannot be null or empty !");
                }

                var deleteCourses = await courseRepository.DeleteCourses(courseDtos.ToList());

                if (deleteCourses == false)
                {
                    return NotFound();
                }

                return Ok(new { message = "Records deleted success", StatusCode = 200, Status = deleteCourses });
            }

            catch (Exception ex)
            {
                if (ex.Message.Contains("modified or deleted"))
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
