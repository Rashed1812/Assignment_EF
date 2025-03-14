using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF
{
    [PrimaryKey(nameof(inst_ID),nameof(Course_ID))]
    public class Course_Inst
    {
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public int evaluate { get; set; }
        [ForeignKey(nameof(Course_ID))]
        public virtual Course course { get; set; }
        [ForeignKey(nameof(inst_ID))]
        public virtual Instructor instructor { get; set; }
    }
}
