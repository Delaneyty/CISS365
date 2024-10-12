using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynnSmithPortal
{
    public class Student
    {
        public int studentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int AccessLevel { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string Major { get; set; }
        public int? ApplicationId { get; set; }
    }
}
