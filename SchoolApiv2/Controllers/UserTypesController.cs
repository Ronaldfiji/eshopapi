using AutoMapper;
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
    public class UserTypesController : ControllerBase
    {
        private readonly IUserTypesRepository userTypesRepository;
        private ILogger<UserTypesController> logger;
        private readonly IMapper mapper;

        public UserTypesController(IUserTypesRepository _userTypesRepository, IMapper _mapper, ILogger<UserTypesController> _logger)
        {
            userTypesRepository= _userTypesRepository;
            mapper = _mapper;
            logger = _logger;
        }



        // GET api/<UserTypesController>/5
        [HttpGet("GetUserType/{id:int}")]
        public async Task<ActionResult<RoleDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var userType = await userTypesRepository.Get(id);

                if (userType == null)
                {
                    return NotFound();
                }
                var userTypeDTO = userType.ConvertToDto();
                return Ok(userTypeDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: UserTypeController/Details/Student
        [HttpGet("Get/{name}")]
        public async Task<ActionResult<UserTypeDto>> GetByName(string name)
        {

            var httpResponse = new HttpResponseMessage();

            try
            {
                var userType = await this.userTypesRepository.GetUserTypeByName(name);
                if (userType == null)
                {
                    return NotFound();
                }

                var userTypeDto = userType.ConvertToDto();
                return Ok(userTypeDto);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<UserTypesController/GetUserTypes>
        [HttpGet("GetUserTypes")]
        public async Task<ActionResult> Get()
        {
            try
            {
                var userTypesList = await userTypesRepository.GetUserTypes();

                if (userTypesList == null)
                {
                    return NotFound();
                }

                var userTypesListDtos = userTypesList.ConvertToDto();              
                return Ok(userTypesListDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // GET: api/<UserTypeController/Create>
        [HttpPost("Create")]
        public async Task<ActionResult<UserTypeDto>> PostItem([FromBody] UserTypeToEditDto userTypeToEdit)
        {
            try
            {
                if (userTypeToEdit == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(UserTypeToEditDto)} cannot be null or empty !");
                }
                //Check if same item exist in db.

               
                var userType = await userTypesRepository.GetUserTypeByName(userTypeToEdit.Name);
                if (userType != null)
                {
                    ModelState.AddModelError("email", $"User Type with name ' {userTypeToEdit.Name} ' exist in database, provide different name !");
                    return BadRequest(ModelState);
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    userTypeToEdit.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var newUserType = await this.userTypesRepository.CreateUserType(userTypeToEdit);

                if (newUserType == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newUserType?.ID})");
                }

                var newUserTypeDto = newUserType.ConvertToDto();
                return CreatedAtAction(nameof(GetItem), new { id = newUserType.ID }, newUserTypeDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // Delete: UserTypeController/Delete/5
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<UserTypeDto>> DeleteItem(int id)
        {
            try
            {
                var deletedUserType = await userTypesRepository.DeleteUserType(id);

                if (deletedUserType == null)
                {
                    return NotFound();
                }
                var userTypeDto = deletedUserType.ConvertToDto();
                //var userMapper = mapper.Map<UserDto>(deletedUser);

                return Ok(userTypeDto); // or ' return NoContent();'

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
