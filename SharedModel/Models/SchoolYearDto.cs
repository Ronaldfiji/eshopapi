

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SharedModel.Models
{
    public class SchoolYearDto
    {
        public int Id { get; set; }
        public int Year { get; set; }       
        public string Code { get; set; } = string.Empty;      
        public string? Description { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }

    public class SchoolYearToEditDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Provide student year")]
        public int Year { get; set; }
        [StringLength(10, ErrorMessage = "Code should be 10 characters or less.")]
        public string Code { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Description should be 100 characters or less.")]
        public string? Description { get; set; } = string.Empty;

        [JsonIgnore]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        [JsonIgnore]
        public string? IPAddress { get; set; } = string.Empty;
    }
}
