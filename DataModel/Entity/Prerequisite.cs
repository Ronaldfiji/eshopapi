using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entity
{
    [Table("Prerequisite", Schema = "SchoolApi")]
    public class Prerequisite : BaseEntity
    {
        public int CourseID { get; set; }
        public int PrerequisiteCourseId { get; set; }

        public Course Course { get; set; }
    }
}
