using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF
{
    class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public int salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int Dept_Id { get; set; }
        public ICollection<Department> departments { get; set; } = new HashSet<Department>();
        public ICollection<Course_Inst> course_Insts { get; set; }


    }
}
