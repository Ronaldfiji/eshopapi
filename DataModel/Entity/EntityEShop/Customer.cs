using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entity.EntityEShop
{
    
    [Table("Customer", Schema = "EShopDb")]
    public class Customer : BaseEntity
    {
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

        [DataType(DataType.Password), MaxLength(200)]
        public string Password { get; set; } = string.Empty;
       

    }
}
