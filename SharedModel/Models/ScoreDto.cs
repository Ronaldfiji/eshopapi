using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace SharedModel.Models
{
    public class ScoreDto
    {
        public int Id { get; set; }
        public int EnrollmentID { get; set; }
        public int AssessmentID { get; set; }
        public int? Weight { get; set; }
        public decimal? Grade { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? AssessmentDate { get; set; }

        [Required(ErrorMessage = "Assessed by required !"), StringLength(30, ErrorMessage = "Assessed by should be 30 characters or less.")]
        public string AssessedBy { get; set; } = string.Empty;

        public AssessmentDto AssessmentDto { get; set; } = null!;
        public EnrollmentDto EnrollmentDto { get; set; } = null!;

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;

    }
    public class ScoreToEditDto
    {
        public int Id { get; set; }
        public int EnrollmentID { get; set; }
        public int AssessmentID { get; set; }
        public int? Weight { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal? Grade { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? AssessmentDate { get; set; }

        [Required(ErrorMessage = "Assessed by required !"), StringLength(30, ErrorMessage = "Assessed by should be 30 characters or less.")]
        public string AssessedBy { get; set; } = string.Empty;

        [JsonIgnore]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        [JsonIgnore]
        public string? IPAddress { get; set; } = string.Empty;
    }

}
