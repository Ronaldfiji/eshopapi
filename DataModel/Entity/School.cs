using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DataModel.Entity
{
    [Table("School", Schema = "SchoolApi")]
    public class School : BaseEntity
    {
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
    }
}
