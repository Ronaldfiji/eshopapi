using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolApiv2.Repository.Contracts.EShopRepositoryContracts;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolApiv2.Controllers.eShop
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private ILogger<PaymentController> logger;
        private readonly IMapper mapper;

        public PaymentController(IProductRepository _productRepository, ILogger<PaymentController> _logger, IMapper _mapper)
        {
            productRepository = _productRepository;
            logger = _logger;
            mapper = _mapper;
        }

        // GET: api/ProductController/GetPaymentToken/
        [AllowAnonymous]
        [HttpGet("GetPaymentToken")]
        public async Task<ActionResult> GetPaymentToken()
        {
            try
            {
                HttpClient httpClient = new HttpClient();

                // Obtain a JWT token.
                StringContent httpContent = new StringContent(@"{ ""email"": ""john@mail.com"", ""password"": ""123"" }", Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("https://localhost/api/user/Login/", httpContent);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
