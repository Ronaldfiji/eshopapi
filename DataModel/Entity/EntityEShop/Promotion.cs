using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entity.EntityEShop
{
    [Table("Promotion", Schema = "EShopDb")]
    public class Promotion: BaseEntity
    {
        public Promotion(){
            product = new HashSet<Product>();
        }
        
        public string Code { get; set; } = string.Empty;
        
        private DateTime? dateFrom;
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime DateFrom
        {
            get
            {
                return this.dateFrom.HasValue
                   ? this.dateFrom.Value
                   : DateTime.UtcNow.AddHours(12);
            }

            set { this.dateFrom = value; }
        }
        private DateTime? dateTo;
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime DateTo
        {
            get
            {
                return this.dateTo.HasValue
                   ? this.dateTo.Value
                   : DateTime.UtcNow.AddHours(12);
            }

            set { this.dateTo = value; }
        }
        
        [Precision(9, 2) ]
        public decimal DiscountPercent { get; set; }
        [DataType(DataType.Currency)]
        [Precision(9, 2) ]
        public decimal DiscountAmount { get; set; }
        public decimal DiscountValue { get; set; }
        public bool Staus { get; set; }
        public virtual ICollection<Product> product { get; set; } 
    }
}
