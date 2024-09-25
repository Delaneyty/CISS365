namespace LynnSmithPortal.Models
{
    public class CourseEnrollment
    {
        public int CourseEnrollmentId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string Status { get; set; } // Enrolled, Dropped, Completed
        public string Grade { get; set; }  // A, B, C, etc.
    }
}
