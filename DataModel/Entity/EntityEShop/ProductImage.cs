using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Entity.EntityEShop
{
    [Table("ProductImage", Schema = "EShopDb")]
    public class ProductImage : BaseEntity
    {        
        public string Name { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
