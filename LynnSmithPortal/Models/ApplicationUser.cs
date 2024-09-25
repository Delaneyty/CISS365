using Microsoft.AspNetCore.Identity;

namespace LynnSmithPortal.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Role { get; set; } // Student, Faculty, Admin
        public bool IsApproved { get; set; } // Used for approval of student applications
    }
}
