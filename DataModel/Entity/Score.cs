using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Entity
{
    [Table("Score", Schema = "SchoolApi")]
    public class Score : BaseEntity
    {      
        public int EnrollmentID { get; set; }
        public int AssessmentID { get; set; }
        public int? Weight { get; set; }
        [Precision(4, 2)]
        public decimal? Grade { get; set; }

         
        public Assessment Assessment { get; set; } 
        public Enroll Enrollment { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? AssessmentDate { get; set; }

        [Required(ErrorMessage = "Assessed by required !"), StringLength(30, ErrorMessage = "Assessed by should be 30 characters or less.")]
        public string AssessedBy { get; set; } = string.Empty;


    }
}
