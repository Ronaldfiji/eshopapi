using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity
{
    [Table("Assessment", Schema = "SchoolApi")]
    public class Assessment : BaseEntity
    {
        [Required(ErrorMessage = "Code is required !"), StringLength(10, ErrorMessage = "Code should be 10 characters or less.")]
        public string Code { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Name should be 100 characters or less.")]
        public string Name { get; set; } = string.Empty;
        public int Weight { get; set; }
        public int SubjectID { get; set; }
        public Subject Subject { get; set; } = null!;
        public int? TermID { get; set; }
        public Term Term { get; set; } = null!;

    }
}
