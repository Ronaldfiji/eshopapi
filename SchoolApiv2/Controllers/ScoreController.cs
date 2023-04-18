
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository;
using SchoolApiv2.Repository.Contracts;
using SharedModel.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolApiv2.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {


        private readonly IScoreRepository scoreRepository;
        private ILogger<ScoreController> logger;      

        public ScoreController(IScoreRepository _scoreRepository, ILogger<ScoreController> _logger)
        {
            scoreRepository = _scoreRepository;           
            logger = _logger;
        }

        // GET api/<ScoreController>GetScore/5
        [HttpGet("GetScore/{id:int}")]
        public async Task<ActionResult<ScoreDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var score = await scoreRepository.Get(id);

                if (score == null)
                {
                    return NotFound();
                }

                var scoreDto = score.ConvertToDto();

                return Ok(scoreDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<ScoreController/GetScores>
        [HttpGet("GetScores")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                if (!string.IsNullOrEmpty( pagingRequestDto.ColumnName) &&
                    pagingRequestDto.ColumnName.ToLower() == "assessmentdate") {
                    
                    if(string.IsNullOrEmpty( pagingRequestDto.SearchTerm))
                    {
                        return BadRequest("Provide valid date !");
                    }
                    DateTime dateTime= DateTime.Parse(pagingRequestDto.SearchTerm);
                    
                }
                var pagedScores = await this.scoreRepository.GetAllScores(pagingRequestDto);                

                if (pagedScores == null)
                {
                    return NotFound();
                }
                var scoresDtos = pagedScores.ConvertToDto();

                var pagedResponse = new PagingResponse<ScoreDto>
                {
                    Items = scoresDtos.ToList(),
                    MetaData =pagedScores.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch(FormatException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // GET: ScoreController/Details/Y9COMM
        [HttpGet("GetScoresByEnrollmentId/{id:int}")]
        public async Task<ActionResult<ScoreDto>> GetByEnrollment(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var scores = await this.scoreRepository.GetByEnrollment(id);
                if (scores == null)
                {
                    return NotFound();
                }
                var scoreDtos = scores.ConvertToDto();
                return Ok(scoreDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        // POST: api/<ScoreController/Create>    
        [HttpPost("Create")]
        public async Task<ActionResult<ScoreDto>> PostItem([FromBody] ScoreToEditDto scoreToEditDto)
        {
            try
            {
                if (scoreToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(ScoreToEditDto)} cannot be null or empty !");
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    scoreToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                } 
                
                var newScore = await this.scoreRepository.CreateScore(scoreToEditDto);

                if (newScore == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newScore?.ID})");
                }

                var newScoreDto = newScore.ConvertToDto();

                return CreatedAtAction(nameof(GetItem), new { id = newScore.ID }, newScoreDto);
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


        //PATCH: api/ScoreController/UpdateScore{int id, ScoreToEditDto}           
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdateScore(int id, [FromBody] ScoreToEditDto scoreToEditDto)
        {
            try
            {
                if (scoreToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(ScoreToEditDto)} cannot be null or empty !");
                }

                if (id != scoreToEditDto.Id)
                    return BadRequest("Score ID mismatch !");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    scoreToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                scoreToEditDto.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updateScore = await this.scoreRepository.UpdateScore(scoreToEditDto);

                if (updateScore == null)
                {
                    return NotFound();
                }
                var score = await scoreRepository.Get(id);

                var scoreDto = score.ConvertToDto();
                return Ok(scoreDto);
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


        // DELETE api/<ScoreController>/Delete/5     
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<ScoreDto>> DeleteItem(int id)
        {
            try
            {               
                var deletedItem = await scoreRepository.DeleteScore(id);

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
