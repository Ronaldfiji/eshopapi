using AutoMapper;
using DataModel.Entity;
using Microsoft.AspNetCore.Mvc;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SharedModel.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolApiv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository roleRepository;
        private ILogger<RoleController> logger;
        private readonly IMapper mapper;

        public RoleController(IRoleRepository _roleRepository, IMapper _mapper, ILogger<RoleController> _logger)
        {
            roleRepository= _roleRepository;
            mapper = _mapper;
            logger = _logger;
        }


        
        // GET api/<RoleController>/5
        [HttpGet("GetUser/{id:int}")]
        public async Task<ActionResult<RoleDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var role = await this.roleRepository.Get(id);

                if (role == null)
                {
                    return NotFound();
                }
                var roleDTO = role.ConvertToDto();
                return Ok(roleDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<RoleController/GetRoles>
        [HttpGet("GetRoles")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {

            try
            {
                var pagedRoles = await this.roleRepository.GetAllRoles(pagingRequestDto);

                if (pagedRoles == null)
                {
                    return NotFound();
                }

                var rolesDtos = pagedRoles.ConvertToDto();

                var pagedResponse = new PagingResponse<RoleDto>
                {
                    Items = rolesDtos.ToList(),
                    MetaData = pagedRoles.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // GET: api/<RoleController/Create>
        [HttpPost("Create")]
        public async Task<ActionResult<UserDto>> PostItem([FromBody] RoleToAddEditDto roleToAddEditDto)
        {
            try
            {
                if (roleToAddEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(UserToAddDto)} cannot be null or empty !");
                }
                //Check if same item exist in db.

                var role = await roleRepository.GetRoleByName(roleToAddEditDto.Name);
                if (role != null)
                {
                    ModelState.AddModelError("email", "Role exist in database, provide different name !");
                    return BadRequest(ModelState);
                }
              
                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    roleToAddEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var newRole = await this.roleRepository.CreateRole(roleToAddEditDto);
               
                if (newRole == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newRole?.ID})");
                }

                var newRoleDto = newRole.ConvertToDto();
                return CreatedAtAction(nameof(GetItem), new { id = newRole.ID }, newRoleDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


      
        //[HttpPatch("Update/{id:int, UserToEditDto}")]        
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdateRole(int id, [FromBody] RoleToAddEditDto roleToAddEdit)
        {
            try
            {
                if (roleToAddEdit == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(RoleToAddEditDto)} cannot be null or empty !");
                }

                if (id != roleToAddEdit.Id)
                    return BadRequest("Role profile ID mismatch");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    roleToAddEdit.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                roleToAddEdit.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedRole = await this.roleRepository.UpdateRole(id, roleToAddEdit);
                if (updatedRole == null)
                {
                    return NotFound();
                }
                var updatedRoleDto = updatedRole.ConvertToDto();
                return Ok(updatedRoleDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }


        // Delete: RoleController/Delete/5

        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<RoleDto>> DeleteItem(int id)
        {
            try
            {
                var deletedRole = await roleRepository.DeleteRole(id);               
              
                if (deletedRole == null)
                {
                    return NotFound();
                }
                //var deletedDto = deletedProduct.ConvertToDto();
                var roleMapper = mapper.Map<RoleDto>(deletedRole);

                return Ok(roleMapper); // or ' return NoContent();'
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
