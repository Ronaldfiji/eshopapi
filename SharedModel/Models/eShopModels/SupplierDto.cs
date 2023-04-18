using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Models.eShopModels
{
    public class SupplierDto
    {

        public int ID { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }
    public class SupplierAddEditDto
    {
        public int ID { get; set; }
        [StringLength(6, ErrorMessage = "Supplier Code cannot be more than 6 characters long.")]
        [Required]
        public string Code { get; set; } = String.Empty;
        [StringLength(30, ErrorMessage = "Supplier Name cannot be more than 30 characters long.")]
        [Required]
        public string Name { get; set; } = String.Empty;
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; } = String.Empty;
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[0-9]{7,10}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = String.Empty;
        [StringLength(30, ErrorMessage = "Address cannot be more than 30 characters long.")]
        public string Address { get; set; } = String.Empty;
        [StringLength(20, ErrorMessage = "City cannot be more than 20 characters long.")]
        [DataType(DataType.Text)]
        public string City { get; set; } = String.Empty;
        public string IPAddress { get; set; } = string.Empty;
    }
}
