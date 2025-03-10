using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF
{
    class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_Id { get; set; }
        public Topic topic { get; set; }
        public ICollection<Stud_Course> stud_Courses { get; set; } = new HashSet<Stud_Course>();
        public ICollection<Course_Inst> course_Insts { get; set; } = new HashSet<Course_Inst>();

    }
}
