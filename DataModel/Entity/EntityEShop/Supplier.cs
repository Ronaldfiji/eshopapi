using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity.EntityEShop
{
    [Table("Supplier", Schema = "EShopDb")]
    public class Supplier : BaseEntity    {
        [StringLength(6, ErrorMessage = "Supplier Code cannot be more than 6 characters long.")]
        [Required]      
        public string Code { get; set; } = String.Empty;
        public string Name { get; set; }= String.Empty;
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        //[Required(ErrorMessage = "Email is reqiured !")]
        public string Email { get; set; }=String.Empty;
        [DataType(DataType.PhoneNumber)]
        //[Required(ErrorMessage = "You must provide phone number")]        
        [RegularExpression(@"^[0-9]{7,10}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }= String.Empty ;
        [StringLength(30, ErrorMessage = "Address cannot be more than 30 characters long.")]
        //[Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = String.Empty;
        [StringLength(20, ErrorMessage = "City cannot be more than 20 characters long.")]
        //[Required(ErrorMessage = "City is required")]
        [DataType(DataType.Text)]
        public string City { get; set; } = String.Empty;


    }
}
