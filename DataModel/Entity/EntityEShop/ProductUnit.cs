
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity.EntityEShop
{
    [Table(nameof(ProductUnit), Schema = "EShopDb")]
    public class ProductUnit: BaseEntity
    {
        
        public string Unit { get; set; } = string.Empty;
        public float Weight { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
