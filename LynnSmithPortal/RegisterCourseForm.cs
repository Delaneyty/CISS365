using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LynnSmithPortal
{
    public partial class RegisterCourseForm : Form
    {
        private int selectedSemester = 0; // 1 = fall, 2 = spring
        private Student student;
        private List<Course> availableCourses;
        private string connectionString = Properties.Settings.Default.customConnString;
        public RegisterCourseForm(Student student)
        {
            InitializeComponent();
            this.student = student;
            availableCourses = new List<Course>();
        }

        private void RegisterCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void fallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the fallRadioButton is selected
            if (fallRadioButton.Checked)
            {
                selectedSemester = 1;  // Set to 1 if Fall is selected
                
                LoadAvailableCourses();
            }
        }

        private void springRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the springRadioButton is selected
            if (springRadioButton.Checked)
            {
                selectedSemester = 2;  // Set to 2 if Spring is selected
               
                LoadAvailableCourses();
            }
        }

        private void registerCourseButton_Click(object sender, EventArgs e)
        {
            // Get selected courses
            var selectedCourses = new List<Course>();
            foreach (var item in courseListBox.CheckedItems)
            {
                var course = availableCourses.FirstOrDefault(c => c.CourseName == item.ToString());
                if (course != null)
                {
                    selectedCourses.Add(course);
                }
            }
            //register for the course
            foreach (var course in selectedCourses)
            {
                RegisterStudentForCourse(student.Id, course.CourseId);
            }

            MessageBox.Show("Courses registered successfully!");
        }


        // Method to register the student for selected courses in the database
        private void RegisterStudentForCourse(int studentId, int courseId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO users.StudentCourses (StudentId, CourseId) " +
                               "VALUES (@StudentId, @CourseId)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);
                    command.Parameters.AddWithValue("@CourseId", courseId);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Course successfully registered for student.");
                    }
                    else
                    {
                        MessageBox.Show("Error registering course.");
                    }
                }
            }
        }

        private void LoadAvailableCourses()
        {
            List<Course> allCourses = GetCoursesBySemester(selectedSemester);

            // Retrieve the course IDs of enrolled and completed courses
            var enrolledOrCompleted = GetEnrolledAndCompletedCourseIds(student.Id);

            // Filter out the courses the student is already enrolled in or has completed
            availableCourses = allCourses
                .Where(course => !enrolledOrCompleted.Contains(course.CourseId))
                .ToList();

            // Clear the previous list
            courseListBox.Items.Clear();

            // Populate the ListBox with the available courses
            foreach (var course in availableCourses)
            {
                courseListBox.Items.Add(course.CourseName);
            }
        }

        private List<int> GetEnrolledAndCompletedCourseIds(int studentId)
        {
            var enrolledOrCompletedCourseIds = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query for enrolled courses (StudentCourses)
                string enrolledQuery = "SELECT CourseId FROM users.StudentCourses WHERE StudentId = @StudentId";

                using (SqlCommand command = new SqlCommand(enrolledQuery, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            enrolledOrCompletedCourseIds.Add(reader.GetInt32(0)); // Add CourseId to the list
                        }
                    }
                }

                // Query for completed courses (CompletedCourses)
                string completedQuery = "SELECT CourseId FROM users.CompletedCourses WHERE StudentId = @StudentId";

                using (SqlCommand command = new SqlCommand(completedQuery, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            enrolledOrCompletedCourseIds.Add(reader.GetInt32(0)); // Add CourseId to the list
                        }
                    }
                }
            }

            return enrolledOrCompletedCourseIds;
        }



        private List<Course> GetCoursesBySemester(int semester)
        {
            // This method would query the database to get courses for the selected semester.
            // Example:
            List<Course> courses = new List<Course>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT CourseId, CourseName, Semester, Credits, SeatsAvailable, DaysOfWeek, Prerequisites " +
                               "FROM users.Courses WHERE Semester = @Semester";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Semester", semester);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new Course(
                                reader.GetInt32(0), // CourseId
                                reader.GetString(1), // CourseName
                                reader.GetInt32(2), // Semester
                                reader.GetInt32(3), // Credits
                                reader.GetInt32(4), // SeatsAvailable
                                reader.GetInt32(5), //students enrolled
                                reader.GetString(6), // DaysOfWeek
                                reader.GetString(7)  // Prerequisites
                            ));
                        }
                    }
                }
            }

            return courses;
        }
    }
}
