using AutoMapper;
using DataModel.Entity;
using Microsoft.AspNetCore.Mvc;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository;
using SchoolApiv2.Repository.Contracts;
using SharedModel.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolApiv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessmentController : ControllerBase
    {
        private readonly IAssessmentRepository assessmentRepository;
        private ILogger<AssessmentController> logger;
        private readonly IMapper mapper;

        public AssessmentController(IAssessmentRepository _assessmentRepository, IMapper _mapper, ILogger<AssessmentController> _logger)
        {            
            assessmentRepository= _assessmentRepository;
            mapper = _mapper;
            logger = _logger;
        }

        // GET api/<AssessmentController>GetAssessment/5
        [HttpGet("GetAssessment/{id:int}")]
        public async Task<ActionResult<AssessmentDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var assessment = await assessmentRepository.Get(id);

                if (assessment == null)
                {
                    return NotFound();
                }

                var assessmentDTO = assessment.ConvertToDto();

                return Ok(assessmentDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        // GET: api/<AssessmmentController/GetAssessmments>
        [HttpGet("GetAssessmments")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                var pagedAssessmment = await this.assessmentRepository.GetAllAssessment(pagingRequestDto);

                if (pagedAssessmment == null)
                {
                    return NotFound();
                }
                var assessmentDtos = pagedAssessmment.ConvertToDto();

                var pagedResponse = new PagingResponse<AssessmentDto>
                {
                    Items = assessmentDtos.ToList(),
                    MetaData = pagedAssessmment.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }


        // GET: AssessmentController/Details/Y9COMM
        [HttpGet("Get/{code}")]
        public async Task<ActionResult<AssessmentDto>> GetByCode(string code)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var assessment = await this.assessmentRepository.GetByCode(code);
                if (assessment == null)
                {
                    return NotFound();
                }
                var assessmentDto = assessment.ConvertToDto();
                return Ok(assessmentDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        // GET: api/<AssessmentController/Create>        
        [HttpPost("Create")]
        public async Task<ActionResult<SubjectDto>> PostItem([FromBody] AssessmentToEditDto assessmentToEditDto)
        {
            try
            {
                if (assessmentToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(assessmentToEditDto)} cannot be null or empty !");
                }

                
                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    assessmentToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }
                
                //Check if same item exist in db.
                var assessment = await assessmentRepository.GetByCode(assessmentToEditDto.Code);
                if (assessment != null)
                {
                    ModelState.AddModelError("Assessment", $"Assessment with code {assessmentToEditDto.Code} exist in database !");
                    return BadRequest(ModelState);
                }


                var newAssessment = await this.assessmentRepository.CreateAssessment(assessmentToEditDto);

                if (newAssessment == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newAssessment?.ID})");
                }

                var newAssessmentDto = newAssessment.ConvertToDto();
                return CreatedAtAction(nameof(GetItem), new { id = newAssessment.ID }, newAssessmentDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        //PATCH: AssessmentController/UpdateAssessment{int id, AssessmentToEditDto}           
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdateAssessment(int id, [FromBody] AssessmentToEditDto assessmentToEditDto)
        {
            try
            {
                if (assessmentToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(AssessmentToEditDto)} cannot be null or empty !");
                }

                if (id != assessmentToEditDto.Id)
                    return BadRequest("Subject ID mismatch");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    assessmentToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                assessmentToEditDto.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedAssessment = await this.assessmentRepository.UpdateAssessment(assessmentToEditDto);

                if (updatedAssessment == null)
                {
                    return NotFound();
                }
                var assessment = await assessmentRepository.Get(id);
                var  assessmentDto = assessment.ConvertToDto();
                return Ok(assessmentDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        // Delete: AssessmentController/Delete/5
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<AssessmentDto>> DeleteItem(int id)
        {
            try
            {
                var deletedItem = await assessmentRepository.DeleteAssessment(id);

                if (deletedItem == null)
                {
                    return NotFound();
                }
                var deletedItemDto = deletedItem.ConvertToDto();
                //var userMapper = mapper.Map<UserDto>(deletedUser);
                return Ok(deletedItemDto); // or ' return NoContent();'

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


    }
}
