using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataModel.Entity
{
    [Table("Subject", Schema = "SchoolApi")]
    public class Subject : BaseEntity
    {

        [Required(ErrorMessage = "Code is required !"), StringLength(10, ErrorMessage = "Code should be 10 characters or less.")]
        public string Code { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Name should be 100 characters or less.")]
        public string Name { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Description should be 100 characters or less.")]
        public string? Description { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Reference book should be 100 characters or less.")]
        public string? ReferenceBook { get; set; } = string.Empty;
        public virtual List<CourseSubject> CourseSubject { get; set; } = Enumerable.Empty<CourseSubject>().ToList();
        public virtual List<Assessment> Assessment { get; set; } = Enumerable.Empty<Assessment>().ToList();

    }
}
