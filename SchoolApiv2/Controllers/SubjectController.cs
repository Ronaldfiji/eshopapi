using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository;
using SchoolApiv2.Repository.Contracts;
using SharedModel.Models;
using System.ComponentModel;
using System.Data;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolApiv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepository subjectRepository;
        private ILogger<SubjectController> logger;
        private readonly IMapper mapper;

        public SubjectController(ISubjectRepository _subjectRepository, IMapper _mapper, ILogger<SubjectController> _logger)
        {
            subjectRepository= _subjectRepository;
            mapper = _mapper;
            logger = _logger;
        }


        // GET api/<SubjectController>GetSubject/5
        [HttpGet("GetSubject/{id:int}")]
        public async Task<ActionResult<SubjectDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var subject = await subjectRepository.Get(id);

                if (subject == null)
                {
                    return NotFound();
                }

                var subjectDTO = subject.ConvertToDto();

                return Ok(subjectDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        // GET: api/<SubjectController/GetSubjects>
        [HttpGet("GetSubjects")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                var pagedSubjects = await this.subjectRepository.GetAllSubjects(pagingRequestDto);

                if (pagedSubjects == null)
                {
                    return NotFound();
                }
                var subjectDtos = pagedSubjects.ConvertToDto();

                var pagedResponse = new PagingResponse<SubjectDto>
                {
                    Items = subjectDtos.ToList(),
                    MetaData = pagedSubjects.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }


        // GET: SubjectController/Details/Y9COMM
        [HttpGet("Get/{code}")]
        public async Task<ActionResult<SubjectDto>> GetByCode(string code)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var subject = await this.subjectRepository.GetByCode(code);
                if (subject == null)
                {
                    return NotFound();
                }
                var subjectDto = subject.ConvertToDto();
                return Ok(subjectDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        // GET: api/<CourseController/Create>        
        [HttpPost("Create")]
        public async Task<ActionResult<SubjectDto>> PostItem([FromBody] SubjectToEditDto subjectToEditDto)
        {
            try
            {
                if (subjectToEditDto == null || !ModelState.IsValid )
                {
                    return BadRequest($"{nameof(subjectToEditDto)} cannot be null or empty !");
                }

                //Check if same item exist in db.
                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    subjectToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var subject = await subjectRepository.GetByCode(subjectToEditDto.Code);
                if (subject != null)
                {
                    ModelState.AddModelError("Subject", $"Subject with code {subjectToEditDto.Code} exist in database !");
                    return BadRequest(ModelState);
                }


                var newSubject = await this.subjectRepository.CreateSubject(subjectToEditDto);

                if (newSubject == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newSubject?.ID})");
                }

                var newSubjectDto = newSubject.ConvertToDto();
                return CreatedAtAction(nameof(GetItem), new { id = newSubject.ID }, newSubjectDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        //PATCH: SubjectController/UpdateSubject{int id, SubjectToEditDto}           
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdateSubject(int id, [FromBody] SubjectToEditDto subjectToEditDto)
        {
            try
            {
                if (subjectToEditDto == null || !ModelState.IsValid )
                {
                    return BadRequest($"{nameof(UserToEditDto)} cannot be null or empty !");
                }

                if (id != subjectToEditDto.Id)
                    return BadRequest("Subject ID mismatch");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    subjectToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                subjectToEditDto.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedSubject = await this.subjectRepository.UpdateSubject(subjectToEditDto);

                if (updatedSubject == null)
                {
                    return NotFound();
                }
                var subject = await subjectRepository.Get(id);
                var subjectDto = subject.ConvertToDto();
                return Ok(subjectDto);
            }
            
            catch (Exception ex)
            {
                var code = ex.HResult;
                if (code == 2146233088)
                {
                    return BadRequest("Invalid data provided");
                }
                if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                {
                        return BadRequest();                    
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        // Delete: SubjectController/Delete/5
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<SubjectDto>> DeleteItem(int id)
        {
            try
            {
                var deletedSubject = await subjectRepository.DeleteSubject(id);

                if (deletedSubject == null)
                {
                    return NotFound();
                }
                var subjectDto = deletedSubject.ConvertToDto();
                //var userMapper = mapper.Map<UserDto>(deletedUser);
                return Ok(subjectDto); // or ' return NoContent();'

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }




    }
}
