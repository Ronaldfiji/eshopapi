using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace SharedModel.Models.eShopModels
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Display(Name = "First name")]
        [Required(ErrorMessage = "First name is required !"), StringLength(30, ErrorMessage = "First name should be 30 characters or less.")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is required !"), StringLength(30, ErrorMessage = "Last name should be 30 characters or less.")]
        public string LastName { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required(ErrorMessage = "Email is reqiured !")]
        public string Email { get; set; } = String.Empty;


        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number is reqiured !")]
        [RegularExpression(@"^[0-9]{7,10}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = String.Empty;

        [Required(ErrorMessage = "Address is required !"), StringLength(100, ErrorMessage = "Address should be 100 characters or less.")]
        public string AddressLine1 { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Address should be 100 characters or less.")]
        public string AddressLine2 { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required !"), StringLength(20, ErrorMessage = "City name should be 20 characters or less.")]
        public string City { get; set; } = string.Empty;

        [StringLength(20, ErrorMessage = "State name should be 20 characters or less.")]
        public string State { get; set; } = string.Empty;

        [StringLength(10, ErrorMessage = "PostalCode name should be 20 characters or less.")]
        public string PostalCode { get; set; } = string.Empty;

        [StringLength(20, ErrorMessage = "Country name should be 20 characters or less.")]
        public string Country { get; set; } = string.Empty;

        [StringLength(300, ErrorMessage = "Profile picture should be 300 characters or less.")]
        public string PictureUrl { get; set; } = string.Empty;

        [DataType(DataType.Password), MaxLength(30)]
        public string Password { get; set; } = String.Empty;

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }

    public class CustoemrToEditDto
    {
        public int Id { get; set; }
        [Display(Name = "First name")]
        [Required(ErrorMessage = "First name is required !"), StringLength(30, ErrorMessage = "First name should be 30 characters or less.")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is required !"), StringLength(30, ErrorMessage = "Last name should be 30 characters or less.")]
        public string LastName { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required(ErrorMessage = "Email is reqiured !")]
        public string Email { get; set; } = String.Empty;


        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number is reqiured !")]
        [RegularExpression(@"^[0-9]{7,10}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = String.Empty;

        [Required(ErrorMessage = "Address is required !"), StringLength(100, ErrorMessage = "Address should be 100 characters or less.")]
        public string AddressLine1 { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Address should be 100 characters or less.")]
        public string AddressLine2 { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required !"), StringLength(20, ErrorMessage = "City name should be 20 characters or less.")]
        public string City { get; set; } = string.Empty;

        [ StringLength(20, ErrorMessage = "State name should be 20 characters or less.")]
        public string State { get; set; } = string.Empty;

        [ StringLength(10, ErrorMessage = "PostalCode name should be 20 characters or less.")]
        public string PostalCode { get; set; } = string.Empty;

        [StringLength(20, ErrorMessage = "Country name should be 20 characters or less.")]
        public string Country { get; set; } = string.Empty;

        [StringLength(300, ErrorMessage = "Profile picture should be 300 characters or less.")]
        public string PictureUrl { get; set; } = string.Empty;

        [DataType(DataType.Password), MaxLength(30)]
        public string Password { get; set; } = string.Empty;

        [JsonIgnore]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        [JsonIgnore]
        public string? IPAddress { get; set; } = string.Empty;
    }

    public class CustomerRequestDto
    {
        public int PageSize { get; set; } = 15;
        public int StartIndex { get; set; }

    }
}
