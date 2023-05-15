using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SchoolApiv2.Repository.Contracts.EShopRepositoryContracts;
using SchoolApiv2.Util;
using System.Net.Http.Headers;
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
        private readonly AppSettings appsettings;

        public PaymentController(IProductRepository _productRepository, ILogger<PaymentController> _logger, IMapper _mapper,
            IOptions<AppSettings> _appSettings)
        {
            productRepository = _productRepository;
            logger = _logger;
            mapper = _mapper;
            appsettings = _appSettings.Value;
        }

        // GET: api/ProductController/GetPaymentToken/
        [AllowAnonymous]
        [HttpGet("GetPaymentSession")]
        public async Task<ActionResult> GetPaymentSession()
        {
            try
            {                
                var baseAddress = new Uri(appsettings.WindcaveBasePath);

                using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                {
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic " + appsettings.WindcaveAuthToken);
                      
                    
                    using (var content = new StringContent("{  \"type\": \"purchase\",  \"amount\": \"21.00\",  " +
                        "\"currency\": \"FJD\",  \"merchantReference\": \"1234ABC\", " +
                        " \"callbackUrls\": {    \"approved\": \"http://localhost:3000/payment/paymentsuccess\",  " +
                        "  \"declined\": \"http://localhost:3000/payment/paymentsuccess\",  " +
                        "  \"cancelled\": \"https://example.com/cancel\"  }, " +
                        " \"notificationUrl\": \"https://example.com/txn_result?123\"}", 
                        System.Text.Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("api/v1/sessions", content))
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                            return Ok(responseData);
                        }
                    }   

                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
