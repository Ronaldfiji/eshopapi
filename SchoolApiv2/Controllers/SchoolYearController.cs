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
    public class SchoolYearController : ControllerBase
    {
        private readonly ISchoolYearRepository schoolYearRepository;
        private ILogger<SchoolYearController> logger;

        public SchoolYearController(ISchoolYearRepository _schoolYearRepository, ILogger<SchoolYearController> _logger)
        {
            schoolYearRepository= _schoolYearRepository;
            logger = _logger;
        }

        // GET api/<SchoolYearController>GetSchoolYear/5
        [HttpGet("GetSchoolYear/{id:int}")]
        public async Task<ActionResult<SchoolYearDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var schoolYear = await schoolYearRepository.Get(id);

                if (schoolYear == null)
                {
                    return NotFound();
                }

                var schoolYearDto = schoolYear.ConvertToDto();

                return Ok(schoolYearDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<SchoolYearController/GetSchoolYears>
        [HttpGet("GetSchoolYears")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                var pagedSchoolYear = await this.schoolYearRepository.GetAllSchoolYear(pagingRequestDto);

                if (pagedSchoolYear == null)
                {
                    return NotFound();
                }
                var pagedSchoolYearsDto = pagedSchoolYear.ConvertToDto();

                var pagedResponse = new PagingResponse<SchoolYearDto>
                {
                    Items = pagedSchoolYearsDto.ToList(),
                    MetaData = pagedSchoolYear.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }


        // POST: api/<SchoolYearController/Create>        
        [HttpPost("Create")]
        public async Task<ActionResult<SchoolYearDto>> PostItem([FromBody] SchoolYearToEditDto schoolYearToEditDto)
        {
            try
            {
                if (schoolYearToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(schoolYearToEditDto)} cannot be null or empty !");
                }


                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    schoolYearToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }                

                var newSchoolYear = await this.schoolYearRepository.CreateSchoolYear(schoolYearToEditDto);

                if (newSchoolYear == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newSchoolYear?.ID})");
                }

                var newSchoolYearDto = newSchoolYear.ConvertToDto();
                return CreatedAtAction(nameof(GetItem), new { id = newSchoolYear.ID }, newSchoolYearDto);
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
