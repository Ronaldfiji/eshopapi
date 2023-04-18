using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace SharedModel.Models
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public SchoolYearDto? SchoolYear { get; set; } = null!;
        public ICollection<EnrollmentDto> Enrollments { get; set; } = null!;
        public virtual List<SubjectDto> Subjects { get; set; } = Enumerable.Empty<SubjectDto>().ToList();
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }

    public class CourseToEditDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is required !"), StringLength(10, ErrorMessage = "Code should be 10 characters or less.")]
        public string Code { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Name should be 100 characters or less.")]
        public string Name { get; set; } = string.Empty;
        [StringLength(200, ErrorMessage = "Description should be 200 characters or less.")]
        public string Description { get; set; } = string.Empty;
        public int SchoolYearId { get; set; }
        [JsonIgnore]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;       
        public string? UpdatedBy { get; set; } = string.Empty;
        [JsonIgnore]
        public string IPAddress { get; set; } = string.Empty;

    }
}
