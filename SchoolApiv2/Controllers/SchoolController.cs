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
    public class SchoolController : ControllerBase
    {

        private readonly ISchoolRepository schoolRepository;
        private ILogger<SchoolController> logger;

        public SchoolController(ISchoolRepository _schoolRepository, ILogger<SchoolController> _logger)
        {
            schoolRepository= _schoolRepository;
            logger = _logger;
        }


        // GET api/<SchoolController>GetSchool/5
        [HttpGet("GetSchool/{id:int}")]
        public async Task<ActionResult<SchoolDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var school = await schoolRepository.Get(id);

                if (school == null)
                {
                    return NotFound();
                }

                var schoolDto = school.ConvertToDto();

                return Ok(schoolDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
               
        // GET: api/<SchoolController/GetSchools>
        [HttpGet("GetSchools")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                
                var pagedSchools = await this.schoolRepository.GetAllSchools(pagingRequestDto);

                if (pagedSchools == null)
                {
                    return NotFound();
                }
                var schoolDtos = pagedSchools.ConvertToDto();

                var pagedResponse = new PagingResponse<SchoolDto>
                {
                    Items = schoolDtos.ToList(),
                    MetaData = pagedSchools.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (FormatException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // POST: api/<SchoolController/Create>    
        [HttpPost("Create")]
        public async Task<ActionResult<SchoolDto>> PostItem([FromBody] SchoolToEditDto schoolToEditDto)
        {
            try
            {
                if (schoolToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(SchoolToEditDto)} cannot be null or empty !");
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    schoolToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var newSchool = await this.schoolRepository.CreateSchool(schoolToEditDto);

                if (newSchool == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newSchool?.ID})");
                }

                var newSchoolDto = newSchool.ConvertToDto();

                return CreatedAtAction(nameof(GetItem), new { id = newSchool.ID }, newSchoolDto);
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
    }
}
