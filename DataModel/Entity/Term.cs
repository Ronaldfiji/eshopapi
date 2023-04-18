using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entity
{
    [Table("Term", Schema = "SchoolApi")]
    public class Term : BaseEntity
    {
        public int SchTerm { get; set; }
        public string TermName { get; set; } = string.Empty;
    }
}
