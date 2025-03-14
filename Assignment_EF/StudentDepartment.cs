using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF
{
    [Keyless]
    public class StudentDepartment
    {
        
        public int studentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentAge { get; set; }
        public string StudentAddress { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
