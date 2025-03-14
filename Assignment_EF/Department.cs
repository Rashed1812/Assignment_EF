using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF
{
   public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        public int? Ins_Id { get; set; }
        public virtual Instructor instructor { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

    }
}
