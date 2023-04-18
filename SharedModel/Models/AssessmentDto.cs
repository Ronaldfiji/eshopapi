using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SharedModel.Models
{
    public class AssessmentDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Weight { get; set; }
        public int? SubjectID { get; set; }
        public SubjectDto Subject { get; set; } = null!;
        public int? TermID { get; set; }
        public TermDto Term { get; set; } = null!;
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;


      

    }

    public class AssessmentToEditDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is required !"), StringLength(10, ErrorMessage = "Code should be 10 characters or less.")]

        public string Code { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Name should be 100 characters or less.")]
        public string Name { get; set; } = string.Empty;
        public int Weight { get; set; }
        public int SubjectID { get; set; }
        public int TermID { get; set; }       
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        [JsonIgnore]
        public string? IPAddress { get; set; } = string.Empty;
    }
}
