using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynnSmithPortal
{
    public class Course
    {
        public int CourseId { get; set; } // Unique identifier for the course
        public string CourseName { get; set; } // Name of the course
        public int Semester { get; set; } // 1 = Fall, 2 = Spring
        public int Credits { get; set; } // Number of credits for the course
        public int SeatsAvailable { get; set; } // Available seats in the course
        public int StudentsEnrolled { get; set; } // Number of students enrolled in the course
        public string DaysOfWeek { get; set; } // Days of the week the course is held (e.g., "Mon, Wed, Fri")
        public string Prerequisites { get; set; } // Comma-separated string of prerequisite course names

        // Constructor
        public Course(int courseId, string courseName, int semester, int credits, int seatsAvailable,
                      int studentsEnrolled, string daysOfWeek, string prerequisites)
        {
            CourseId = courseId;
            CourseName = courseName;
            Semester = semester;
            Credits = credits;
            SeatsAvailable = seatsAvailable;
            StudentsEnrolled = studentsEnrolled;
            DaysOfWeek = daysOfWeek;
            Prerequisites = prerequisites;
        }

        // Override ToString to display course name in the UI, if necessary
        public override string ToString()
        {
            return $"{CourseName} ({Credits} credits) - {DaysOfWeek}";
        }
    }

}
