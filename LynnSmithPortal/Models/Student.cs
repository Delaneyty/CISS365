namespace LynnSmithPortal.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public ICollection<CourseEnrollment> CourseEnrollments { get; set; }
    }
}
