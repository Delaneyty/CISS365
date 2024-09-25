using Microsoft.EntityFrameworkCore;

namespace LynnSmithPortal.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public ICollection<CourseEnrollment> CourseEnrollments { get; set; }

        // List of prerequisites as course names (e.g., "CISS 365", "CISS 245")
        public List<string> PrerequisiteCourses { get; set; }

        //TO DO: Later in the controller, this is how we will add a course w pre-req's:

        /*var course = new Course
        {
            CourseName = "CISS 245",
            Credits = 3,
            PrerequisiteCourses = new List<string> { "CISS 240", "CISS 201", etc... }
        };

        _dbContext.Courses.Add(course);
        await _dbContext.SaveChangesAsync();*/


        //Example of displaying the courses:

        /*var course = _dbContext.Courses.Find(courseId);
        var prerequisites = string.Join(", ", course.PrerequisiteCourses);
        Console.WriteLine($"Course: {course.CourseName}, Prerequisites: {prerequisites}");*/
    }
}
