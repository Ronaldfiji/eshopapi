using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity.EntityEShop
{
    [Table("CartItem", Schema = "EShopDb")]
    public class CartItem : BaseEntity
    {
        public int ProductID { get; set; }
        public ushort Quantity { get; set; }

        //[Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        [Precision(12, 2)]
        public decimal Price { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        //[Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        [Precision(12, 2)]
        public decimal SubTotal { get; set; }
    }
}
