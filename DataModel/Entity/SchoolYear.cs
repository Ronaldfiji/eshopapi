
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DataModel.Entity
{
    [Table("SchoolYear", Schema = "SchoolApi")]
    public class SchoolYear : BaseEntity
    {
        [Required(ErrorMessage = "Provide student year"), Range(1,13, ErrorMessage ="Year should be from 1 to 13 !")]
        public int Year { get; set; }
        [StringLength(10, ErrorMessage = "Code should be 10 characters or less.")]
        public string Code { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Description should be 100 characters or less.")]
        public string? Description { get; set; } = string.Empty;
    }
}
