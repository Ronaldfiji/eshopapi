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
    public class PrerequisiteController : ControllerBase
    {
        private readonly IPrerequisiteRepository prerequisiteRepository;       
        private ILogger<PrerequisiteController> logger;


        public PrerequisiteController(IPrerequisiteRepository _prerequisiteRepository, ILogger<PrerequisiteController> _logger,
            IScoreRepository _scoreRepository)
        {
            prerequisiteRepository= _prerequisiteRepository;
            logger = _logger;
           
        }

        // GET api/<PrerequisiteController>Get/5
        [HttpGet("Get/{id:int}")]
        public async Task<ActionResult<PrerequisiteDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var prerequisite = await prerequisiteRepository.Get(id);

                if (prerequisite == null)
                {
                    return NotFound();
                }

                var prerequisiteDto = prerequisite.ConvertToDto();
                return Ok(prerequisiteDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/<PrerequisiteController>GetByCourse/5
        [HttpGet("GetByCourse/{id:int}")]
        public async Task<ActionResult<PrerequisiteDto>> GetByCourse(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var prerequisite = await prerequisiteRepository.GetByCourse(id);

                if (prerequisite == null)
                {
                    return NotFound();
                }

                var prerequisiteDto = prerequisite.ConvertToDto();
                return Ok(prerequisiteDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        // GET: api/<PrerequisiteController/GetPrerequisites>
        [HttpGet("GetPrerequisites")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                var pagedPrerequisite = await this.prerequisiteRepository.GetAllPrerequisite(pagingRequestDto);

                if (pagedPrerequisite == null)
                {
                    return NotFound();
                }
                var prerequisiteDtos = pagedPrerequisite.ConvertToDto();

                var pagedResponse = new PagingResponse<PrerequisiteDto>
                {
                    Items = prerequisiteDtos.ToList(),
                    MetaData = pagedPrerequisite.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // POST: api/<PrerequisiteController/Create>        
        [HttpPost("Create")]
        public async Task<ActionResult<PrerequisiteDto>> PostItem([FromBody] PrerequisiteToEditDto prerequisiteToEditDto)
        {
            try
            {
                if (prerequisiteToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(PrerequisiteToEditDto)} cannot be null or empty !");
                }


                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    prerequisiteToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var newPrerequisite = await this.prerequisiteRepository.CreatePrerequisite(prerequisiteToEditDto);

                if (newPrerequisite == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newPrerequisite?.ID})");
                }

                var newPrerequisiteDto = newPrerequisite.ConvertToDto();

                return CreatedAtAction(nameof(GetItem), new { id = newPrerequisite.ID }, newPrerequisiteDto);
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


        //PATCH: api/PrerequisiteController/UpdatePrerequisite{int id, PrerequisiteToEditDto}           
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdatePrerequisite(int id, [FromBody] PrerequisiteToEditDto prerequisiteToEditDto)
        {
            try
            {
                if (prerequisiteToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(PrerequisiteToEditDto)} cannot be null or empty !");
                }

                if (id != prerequisiteToEditDto.Id)
                    return BadRequest("Prerequisite ID mismatch !");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    prerequisiteToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                prerequisiteToEditDto.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedPrerequisite = await this.prerequisiteRepository.UpdatePrerequisite(prerequisiteToEditDto);

                if (updatedPrerequisite == null)
                {
                    return NotFound();
                }
                var prerequisite = await prerequisiteRepository.Get(id);

                var prerequisiteDto = prerequisite.ConvertToDto();
                return Ok(prerequisiteDto);
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

        // DELETE api/<PrerequisiteController>/Delete/5     
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<PrerequisiteDto>> DeleteItem(int id)
        {
            try
            {
                var deletedItem = await prerequisiteRepository.DeletePrerequisite(id);

                if (deletedItem == null)
                {
                    return NotFound($"Failed to delete object {nameof(PrerequisiteDto)} with id : {id}");
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
