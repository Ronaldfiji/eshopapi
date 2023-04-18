using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity.EntityEShop
{
    [Table("Product", Schema = "EShopDb")]
   
    public class Product : BaseEntity
    {
        public Product(){
            promotions = new HashSet<Promotion>();           
        }             
       
        [Display(Name ="Product Code")]
        [Required(ErrorMessage ="Product code is required !"), StringLength(10, ErrorMessage = "Product code should be 10 chars long.")]       
        public string Code { get; set; } = string.Empty;
        [Display(Name ="Product Name")]
        [Required(ErrorMessage ="Product name is required !"), StringLength(60, ErrorMessage = "Product name should be 30 chars long.")]        
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } // ushort - Unsigned 16 bit integer (-32,768 - 32,768)
        [Precision(9, 2)]
        public decimal UnitPrice { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        [Range(1,5, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Rating { get; set; } = 1;
        [Required(ErrorMessage ="Category  is required !")]
        public int CategoryID { get; set; }  
        [Required(ErrorMessage ="Supplier  is required !")]      
        public int? SupplierID { get; set; }
        public int? ProductUnitID { get; set; }
        public int? UserID { get; set; }
        public bool IsOnPromotion { get; set; } 
        [ForeignKey("CategoryID")]
        public Category Category { get; set; } = null!;
        public Supplier Supplier { get; set; } = null!;
        public ProductUnit? ProductUnit { get; set; } 
        public User User { get; set; }
        public virtual ICollection<Promotion> promotions { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }


}
