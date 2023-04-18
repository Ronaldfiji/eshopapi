using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entity
{
    [Table("Course", Schema = "SchoolApi")]
    public class Course : BaseEntity
    {
        /*public Course() { // Build many-to-many relationship automatically
            this.Subject = new HashSet<Subject>();
        }*/

        [Required(ErrorMessage = "Code is required !"), StringLength(10, ErrorMessage = "Code should be 10 characters or less.")]
        public string Code { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Name should be 100 characters or less.")]
        public string Name { get; set; } = string.Empty;
        [StringLength(200, ErrorMessage = "Description should be 200 characters or less.")]
        public string Description { get; set; } = string.Empty;
        public int SchoolYearId { get; set; }
        public SchoolYear SchoolYear { get; set; } = null!;
        public ICollection<Enroll> Enrollments { get; set; } = null!;
        public virtual List<CourseSubject> CourseSubject { get; set; } = Enumerable.Empty<CourseSubject>().ToList();
        //public virtual ICollection<Subject> Subject { get; set; }

    }
}
