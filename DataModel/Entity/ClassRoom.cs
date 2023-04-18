
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Entity
{
    [Table("ClassRoom", Schema = "SchoolApi")]
    public class ClassRoom : BaseEntity
    {
        [Required(ErrorMessage = "Code is required !"), StringLength(10, ErrorMessage = "Code should be 10 characters or less.")]
        public string Code { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Code should be 100 characters or less.")]
        public string Name { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Description should be 100 characters or less.")]
        public string Description { get; set; } = string.Empty;
        public int SchoolId { get; set; }
        //[ForeignKey("SchoolId")]
        public School School { get; set; } = null!;
        //[ForeignKey("SchoolYearId")]
        public int SchoolYearId { get; set; }
        public SchoolYear SchoolYear { get; set; } = null!;
        public int SeatingCapacity { get; set; }
    }
}
