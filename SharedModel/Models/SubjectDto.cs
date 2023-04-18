
using System.ComponentModel.DataAnnotations;

using System.Text.Json.Serialization;


namespace SharedModel.Models
{
    public class SubjectDto
    {

        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string? ReferenceBook { get; set; } = string.Empty;       
       
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
        public virtual ICollection<AssessmentDto> AssessmentDto { get; set; } = Enumerable.Empty<AssessmentDto>().ToList();
    }

    public class SubjectToEditDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is required !"), StringLength(10, ErrorMessage = "Code should be 10 characters or less.")]
        public string Code { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Name should be 100 characters or less.")]
        public string Name { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Description should be 100 characters or less.")]
        public string? Description { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Reference book should be 100 characters or less.")]
        public string? ReferenceBook { get; set; } = string.Empty;
        public int CourseID { get; set; }
        [JsonIgnore]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;        
        public string? UpdatedBy { get; set; } = string.Empty;
        [JsonIgnore]
        public string IPAddress { get; set; } = string.Empty;
    }
}
