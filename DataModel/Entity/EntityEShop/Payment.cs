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
    [Table("Payment", Schema = "EShopDb")]
    public class Payment : BaseEntity
    {
       
        public PaymentTypes PaymentsType { get; set; }
        public string Description { get; set; } = string.Empty;      
        [Precision(9, 2)]
        //[Column(TypeName = "decimal(9,2)")]
        public decimal TotalDue { get; set; }
        [Precision(9, 2)]
        public decimal TotalReceived { get; set; }
        [Precision(9, 2)]
        public decimal CashOut { get; set; }
        public string PaymentRef { get; set; } = string.Empty ;
        public bool IsSuccess { get; set; }
    }

    public enum PaymentTypes
    {   
        Cash = 1,
        [Display(Name = "DebitCard")]
        DebitCard = 2,
        MPaisa = 3,
        [Display(Name = "Credit Card")]
        CreditCard = 4,
        [Display(Name = "Visa Debit Card")]
        VisaDebitCard = 5,
        EFPOS = 6,
        
    }
}
