
using System.ComponentModel.DataAnnotations;


namespace SharedModel.Models.eShopModels
{
    public class CategoryDto
    {

        public int ID { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }

    public class CategoryToAddDto
    {
        public int ID { get; set; }
        [StringLength(10, ErrorMessage = "Category Code cannot be more than 6 characters long.")]
        [Required]
        public string Code { get; set; } = String.Empty;
        [StringLength(30, ErrorMessage = "Name should be 30 chars in length")]
        [Required]
        public string Name { get; set; } = String.Empty;
        [StringLength(100, ErrorMessage = "Category description cannot be more than 100 characters long.")]
        public string Description { get; set; } = string.Empty;
        [StringLength(20, ErrorMessage = "Icon should be 20 chars in length")]
        public string Icon { get; set; } = string.Empty;
        public string IPAddress { get; set; } = string.Empty;

    }

   
}
