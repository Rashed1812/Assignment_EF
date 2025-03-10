using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF
{
    [PrimaryKey(nameof(stud_ID),nameof(Course_ID))]
    class Stud_Course
    {
        public int stud_ID { get; set; }
        public int Course_ID { get; set; }
        public int Grade { get; set; }
        [ForeignKey(nameof(stud_ID))]
        public Student Student { get; set; }
        [ForeignKey(nameof(Course_ID))]
        public Course Course { get; set; }
    }
}
