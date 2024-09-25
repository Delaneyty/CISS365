namespace LynnSmithPortal.Models
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public string FullName { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
