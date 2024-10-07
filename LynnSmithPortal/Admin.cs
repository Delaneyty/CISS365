using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynnSmithPortal
{
    public class Admin
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // Admin Name
        public string Email { get; set; } // Admin Email (Unique)
        public string HashedPassword { get; set; } // Hashed Password for login
        public int AccessLevel { get; set; } = 4; // Access level, 4 for Admin
        public int AdminLevel { get; set; } // Custom field for admin-specific role
        public bool IsSuperAdmin { get; set; } // Flag indicating if admin is a super admin

        // Constructor
        public Admin(int id, string name, string email, string hashedPassword, int adminLevel, bool isSuperAdmin)
        {
            Id = id;
            Name = name;
            Email = email;
            HashedPassword = hashedPassword;
            AdminLevel = adminLevel;
            IsSuperAdmin = isSuperAdmin;
        }

        // Default Constructor
        public Admin() { }
    }
}
