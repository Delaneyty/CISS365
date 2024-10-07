using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynnSmithPortal
{
    public class Faculty
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // Faculty Name
        public string Email { get; set; } // Faculty Email (Unique)
        public string HashedPassword { get; set; } // Hashed Password for login
        public int AccessLevel { get; set; } = 3; // Access level, 3 for Faculty
        public string Department { get; set; } // Faculty's Department
        public DateTime HireDate { get; set; } // Hire Date

        // Constructor
        public Faculty(int id, string name, string email, string hashedPassword, string department, DateTime hireDate)
        {
            Id = id;
            Name = name;
            Email = email;
            HashedPassword = hashedPassword;
            Department = department;
            HireDate = hireDate;
        }

        // Default Constructor
        public Faculty() { }
    }

}
