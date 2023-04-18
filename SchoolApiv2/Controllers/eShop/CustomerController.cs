using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Repository.Contracts.EShopRepositoryContracts;
using SchoolApiv2.Repository.EShopRepository;
using SharedModel.Models;
using SharedModel.Models.eShopModels;
using SharedModel.Models.Util;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolApiv2.Controllers.eShop
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRespository customerRespository;
        private ILogger<CustomerController> logger;
        private readonly IMapper mapper;

        public CustomerController(ICustomerRespository _customerRespository, ILogger<CustomerController> 
            _logger, IMapper _mapper)
        {
            customerRespository= _customerRespository;
            logger = _logger;
            mapper = _mapper;
        }

        // GET api/<CustomerController>GetCustomer/5
        [HttpGet("GetCustomer/{id:int}")]
        public async Task<ActionResult<CategoryDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var customer = await customerRespository.Get(id);

                if (customer == null)
                {
                    return NotFound();
                }

                var customerDto = customer.ConvertToDto();

                return Ok(customerDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<CustomerController/GetCustomers>
        [HttpGet("GetCustomers")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                var pagedCustomers = await this.customerRespository.GetAllCustomers(pagingRequestDto);

                if (pagedCustomers == null)
                {
                    return NotFound();
                }
                var customersDtos = pagedCustomers.ConvertToDto();

                var pagedResponse = new PagingResponse<CustomerDto>
                {
                    Items = customersDtos.ToList(),
                    MetaData = pagedCustomers.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // GET: api/<CustomerController/GetAllVirtualize>
        // This method gets virtualize list of items from DB similar to paging.
        [HttpGet("Getallvirtualize")]
        public async Task<ActionResult> GetAllVirtualize([FromQuery] CustomerRequestDto customerRequestDto)
        {
            try
            {
                var customers = await this.customerRespository.GetAllCustomers(customerRequestDto);

                if (customers == null)
                {
                    return NotFound();
                }

                var allCustomers = customers.Items;
                var totalSize = customers.TotalSize;
                var customersDtos = allCustomers.ConvertToDto();
                var customerVRListDto = new VirtualizeResponse<CustomerDto> { Items = (List<CustomerDto>)customersDtos, TotalSize = totalSize };

                return Ok(customerVRListDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }


        // GET: api/<CustomerController/Get/email>
        [HttpGet("Get/{email}")]
        public async Task<ActionResult<UserDto>> GetByEmail(string email)
        {

            var httpResponse = new HttpResponseMessage();

            try
            {
                var user = await this.customerRespository.GetCustomerByEmail(email);
                if (user == null)
                {
                    return NotFound();
                }

                var userDto = user.ConvertToDto();
                return Ok(userDto);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        // POST: api/<CustomerController/Create>        
        [HttpPost("Create")]
        public async Task<ActionResult<EnrollmentDto>> PostItem([FromBody] CustoemrToEditDto custoemrToEditDto)
        {
            try
            {
                if (custoemrToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(EnrollmentToEditDto)} cannot be null or empty !");
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    custoemrToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var customer = await this.customerRespository.GetCustomerByEmail(custoemrToEditDto.Email);
                if (customer != null)
                {
                    ModelState.AddModelError("email", "Customer email already in use");
                    return StatusCode(StatusCodes.Status409Conflict, $"Customer exist with email { custoemrToEditDto.Email} address. Provide different email address !");
                }
                var newCustomer = await this.customerRespository.CreateCustomer(custoemrToEditDto);

                if (newCustomer == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newCustomer?.ID})");
                }

                var newCustomerDto = newCustomer.ConvertToDto();

                return CreatedAtAction(nameof(GetItem), new { id = newCustomer.ID }, newCustomerDto);
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

        //PATCH: api/CustomerController/UpdateCustomer{int id, CustomerToEditDto}           
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdateCustomer(int id, [FromBody] CustoemrToEditDto custoemrToEditDto)
        {
            try
            {
                if (custoemrToEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(CustoemrToEditDto)} cannot be null or empty !");
                }

                if (id != custoemrToEditDto.Id)
                    return BadRequest("Customer ID mismatch !");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    custoemrToEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                custoemrToEditDto.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedCustomer = await this.customerRespository.UpdateCustomer(custoemrToEditDto);

                if (updatedCustomer == null)
                {
                    return NotFound();
                }
                var customer = await customerRespository.Get(id);

                var customerDto = customer.ConvertToDto();
                return Ok(customerDto);
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

        // DELETE api/<CustomerController>/Delete/5     
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<CustoemrToEditDto>> DeleteItem(int id)
        {
            try
            {
                var deletedItem = await customerRespository.DeleteCustomer(id);

                if (deletedItem == null)
                {
                    return NotFound($"Failed to delete object {nameof(CustomerDto)} with id : {id}");
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
