using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SharedModel.Models
{
    public class SchoolDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }
    public class SchoolToEditDto
    {
        public int Id { get; set; }
        [StringLength(100, ErrorMessage = "Name should be 100 characters or less.")]
        public string Name { get; set; } = string.Empty;
        [StringLength(20, ErrorMessage = "Code should be 20 characters or less.")]
        public string Code { get; set; } = string.Empty;
        [StringLength(200, ErrorMessage = "Description should be 200 characters or less.")]
        public string Description { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Address should be 100 characters or less.")]
        public string Address { get; set; } = string.Empty;
        [StringLength(30, ErrorMessage = "District should be 30 characters or less.")]
        public string District { get; set; } = string.Empty;
        [StringLength(20, ErrorMessage = "City should be 20 characters or less.")]
        public string City { get; set; } = string.Empty;
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required(ErrorMessage = "Email is reqiured !")]
        public string Email { get; set; } = string.Empty;
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[0-9]{7,10}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = string.Empty;
        [JsonIgnore]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        [JsonIgnore]
        public string? IPAddress { get; set; } = string.Empty;
    }
}
