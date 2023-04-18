using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace SharedModel.Models.eShopModels
{
    public class ProductDto
    {
        public int ID { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } // replaced short int Unsigned 16 bit integer (-32,768 - 32,768)       
        public decimal UnitPrice { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        public int Rating { get; set; }
        public int? ProductUnitID { get; set; }
        public bool IsOnPromotion { get; set; }
        public CategoryDto CategoryDto { get; set; } = null!;
        public SupplierDto SupplierDto { get; set; } = null!;
        public int? UserID { get; set; }
        public virtual List<ProductImageDto?> ProductImagesDto { get; set; } = null!;

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }


    public class ProductToEditDto
    {
        public int Id { get; set; }
        [Display(Name = "Product Code")]
        [Required(ErrorMessage = "Product code is required !"), StringLength(10, ErrorMessage = "Product code should be 10 chars long.")]
        public string Code { get; set; } = string.Empty;
        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product name is required !"), StringLength(30, ErrorMessage = "Product name should be 30 chars long.")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } // Unsigned 16 bit integer (-32,768 - 32,768)  
        public decimal UnitPrice { get; set; }
        [Range(1, 5, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Rating { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        [Required(ErrorMessage = "Category  is required !")]
        public int CategoryID { get; set; }       
        public int SupplierID { get; set; }
        public int UserID { get; set; }
        public int? ProductUnitID { get; set; }
        public bool IsOnPromotion { get; set; } = false;
        public virtual List<ProductImagesToAddDto> ProductImagesToAddDto { get; set; } = Enumerable.Empty<ProductImagesToAddDto>().ToList();

        [JsonIgnore]
        public string IPAddress { get; set; } = string.Empty;
        [JsonIgnore]
        public DateTime? CreatedDateTime { get; set; }
        [JsonIgnore]
        public DateTime? ModifiedDate { get; set; }

    }

    public class ProductUnitDto
    {
        public int ID { get; set; }
        public string Unit { get; set; } = string.Empty;
        public float Weight { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string IPAddress { get; set; } = string.Empty;
    }

    public class ProductUnitToEditDto
    {
        public int ID { get; set; }
        public string Unit { get; set; } = string.Empty;
        public float Weight { get; set; }
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]
        public string IPAddress { get; set; } = string.Empty;
        [JsonIgnore]
        public DateTime? CreatedDateTime { get; set; }
        [JsonIgnore]
        public DateTime? ModifiedDate { get; set; }
    }


}
