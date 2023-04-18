using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity
{
    [Table("CourseSubject", Schema = "SchoolApi")]
    public class CourseSubject : BaseRelatedEntity
    {
        public int CourseId { get; set; }
        public int SubjectId { get; set; }        
        public Course? Course { get; set; }
        public Subject? Subject { get; set; }

    }
}
