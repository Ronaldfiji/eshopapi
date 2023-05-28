using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SchoolApiv2.Repository.Contracts.EShopRepositoryContracts;
using SchoolApiv2.Util;
using SharedModel.Models.eShopModels;
using System.Net.Http;
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
        [HttpPost("GetPaymentSession")]
        public async Task<ActionResult> GetPaymentSession([FromBody] PaymentEditDto paymentEditDto)
        {
            try
            {
                if (paymentEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(PaymentEditDto)} cannot be null or empty !");
                }

                var baseAddress = new Uri(appsettings.WindcaveBasePath);

                using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                {
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic " + appsettings.WindcaveAuthToken);
                    using (var content = new StringContent("{  \"type\": \"" + paymentEditDto.Type + "\",  \"amount\": \"" + paymentEditDto.Amount + "\",  " +
                         "\"currency\": \"" + paymentEditDto.Currency + "\",  \"merchantReference\": \"" + paymentEditDto.MerchantRef + "\", " +
                         " \"callbackUrls\": {    \"approved\": \"" + paymentEditDto.CallbackUrls.Approved + "\",  " +
                         "\"declined\": \"" + paymentEditDto.CallbackUrls.Declined + "\",  " +
                         "\"cancelled\": \"" + paymentEditDto.CallbackUrls.Cancelled + "\"  }, " +
                         "\"notificationUrl\": \"" + paymentEditDto.NotifyUrl + "\" ," +
                         "\"customer\": {    \"firstName\": \"" + paymentEditDto.customerDto.FirstName + "\"," +
                         "\"lastName\": \"" + paymentEditDto.customerDto.LastName + "\" ," +
                         "\"email\": \"" + paymentEditDto.customerDto.Email + "\",  " +
                         "\"phoneNumber\": \"" + paymentEditDto.customerDto.Phone + "\",    " +
                         "\"homePhoneNumber\": \"" + paymentEditDto.customerDto.Phone + "\",    " +
                         "\"account\": \"99999999\", " +
                         " \"shipping\": {\"name\": \"" + paymentEditDto.customerDto.FirstName + ' ' + paymentEditDto.customerDto.LastName + "\",   " +
                         "\"address1\": \"" + paymentEditDto.customerDto.AddressLine1 + "\",      \"address2\": \"\",   " +
                         "\"address3\": \"\",      \"city\": \"" + paymentEditDto.customerDto.City + "\",     " +
                         "\"countryCode\": \"FJ\", \"postalCode\": \"00679\",\"phoneNumber\": \"" + paymentEditDto.customerDto.Phone + "\",\"state\": \"\"   }}}"
                          , System.Text.Encoding.Default, "application/json"))
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

        [HttpGet("GetPaymentDetails/{paymentSessionId}")]
        public async Task<ActionResult> GetPaymentDetails(string paymentSessionId)
        {
            try
            {
                if (string.IsNullOrEmpty( paymentSessionId)  || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(paymentSessionId)} cannot be null or empty !");
                }
                var httpClient = new HttpClient { BaseAddress = new Uri(appsettings.WindcaveBasePath)};
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Basic " + appsettings.WindcaveAuthToken);                                
                var response = await httpClient.GetAsync($"api/v1/sessions/{paymentSessionId}");
                string responseData = await response.Content.ReadAsStringAsync();                
                return Ok(responseData);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }

}
