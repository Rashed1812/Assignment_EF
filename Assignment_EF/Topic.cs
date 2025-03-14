using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> courses { get; set; } = new HashSet<Course>();
    }
}
