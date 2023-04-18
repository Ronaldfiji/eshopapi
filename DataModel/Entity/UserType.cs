using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Entity
{

    [Table("UserType", Schema = "SchoolApi")]
    public class UserType : BaseEntity
    {
        [Required(ErrorMessage = "Type name is required !"), StringLength(100, ErrorMessage = "Name should be 100 characters or less.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Description is required !"), StringLength(100, ErrorMessage = "Description should be 100 characters or less.")]
        public string Description { get; set; } = string.Empty;
    }
}
