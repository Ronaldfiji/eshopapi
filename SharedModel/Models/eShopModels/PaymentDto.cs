
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SharedModel.Models.eShopModels
{
    public class PaymentDto
    {

    }

    public class PaymentEditDto
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Product type is required!"), StringLength(20, ErrorMessage = "Product type should be 20 chars long.")]
        public string Type { get; set; } = string.Empty;

        [Required(ErrorMessage = "Amount is required !")]
        public float Amount { get; set; }

        [Required(ErrorMessage = "Currency is required !"), StringLength(3, ErrorMessage = "Currency should be 3 chars")]
        public string Currency { get; set; } = string.Empty.ToString();

        [Required(ErrorMessage = "MerchantRef is required !"), StringLength(20, ErrorMessage = "MerchantRef should be 20 chars")]
        public string MerchantRef { get; set; } = string.Empty.ToString();

        [Required(ErrorMessage = "Language is required !"), StringLength(2, ErrorMessage = "Language should be 2 chars")]
        public string Language { get; set; } = "en";

        public List<string> Methods { get; set; } = new List<string>();

        public CallBackUrls CallbackUrls { get; set; } = null!;

        [StringLength(200, ErrorMessage = "Notification url should be 200 chars in length")]
        public string NotifyUrl { get; set; } = string.Empty;
     
        public CustomerDto customerDto { get; set; } = null!;

    }

    public class CallBackUrls
    {
        [Required(ErrorMessage = "Approved url is required !"), StringLength(100, ErrorMessage = "Approved url should be 100 chars long")]
        public string Approved { get; set; } = string.Empty.ToString();

        [Required(ErrorMessage = "Declined url is required !"), StringLength(100, ErrorMessage = "Declined url should be 100 chars long")]
        public string Declined { get; set; } = string.Empty.ToString();

        [Required(ErrorMessage = "Cancelled url is required !"), StringLength(100, ErrorMessage = "Cancelled url should be 100 chars long")]
        public string Cancelled { get; set; } = string.Empty.ToString();
    }


}
