using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace LynnSmithPortal
{
    public partial class RegisterCourseForm : Form
    {
        private int selectedSemester = 0; // 1 = fall, 2 = spring
        private Student student;
        private List<Course> availableCourses;
        private Course selectedCourse;
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
            // Ensure a course is selected
            if (selectedCourse == null)
            {
                MessageBox.Show("Please select a course to register.");
                return;
            }

            // Register the student for the selected course
            RegisterStudentForCourse(student.studentId, selectedCourse.CourseId);
        }


        // Method to register the student for selected courses in the database
        private void RegisterStudentForCourse(int studentId, int courseId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert the student-course registration
                    string registerQuery = "INSERT INTO users.StudentCourses (StudentId, CourseId) VALUES (@StudentId, @CourseId)";

                    using (SqlCommand registerCommand = new SqlCommand(registerQuery, connection))
                    {
                        registerCommand.Parameters.AddWithValue("@StudentId", studentId);
                        registerCommand.Parameters.AddWithValue("@CourseId", courseId);

                        int result = registerCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            // Update course availability after successful registration
                            string updateCourseQuery = "UPDATE users.Courses SET SeatsAvailable = SeatsAvailable - 1, StudentsEnrolled = StudentsEnrolled + 1 WHERE CourseId = @CourseId";

                            using (SqlCommand updateCourseCommand = new SqlCommand(updateCourseQuery, connection))
                            {
                                updateCourseCommand.Parameters.AddWithValue("@CourseId", courseId);
                                updateCourseCommand.ExecuteNonQuery(); // Execute the update command
                            }

                            MessageBox.Show("Course successfully registered for student and updated course info.");
                        }
                        else
                        {
                            MessageBox.Show("Error registering course.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void LoadAvailableCourses()
        {
            List<Course> allCourses = GetCoursesBySemester(selectedSemester);

            // Retrieve the course IDs of enrolled and completed courses
            var enrolledOrCompleted = GetEnrolledAndCompletedCourseIds(student.studentId);

            // Filter out the courses the student is already enrolled in or has completed
            availableCourses = allCourses
                .Where(course => !enrolledOrCompleted.Contains(course.CourseId))
                .ToList();

            // Clear the previous list
            courseListBox.Items.Clear();

            // Populate the ListBox with the available courses
            foreach (var course in availableCourses)
            {
                courseListBox.Items.Add(course.ToString()); // Only display course names in the ListBox
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
            List<Course> courses = new List<Course>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT CourseId, CourseName, Semester, Credits, SeatsAvailable, StudentsEnrolled, DaysOfWeek, Prerequisites " +
                               "FROM users.Courses WHERE Semester = @Semester";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Semester", semester);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int courseId = reader.GetInt32(0); // CourseId
                            string courseName = reader.GetString(1); // CourseName
                            int courseSemester = reader.GetInt32(2); // Semester
                            int credits = reader.GetInt32(3); // Credits

                            // Handle possible null values or invalid data types for SeatsAvailable and StudentsEnrolled
                            int seatsAvailable = reader.IsDBNull(4) ? 0 : reader.GetInt32(4); // SeatsAvailable
                            int studentsEnrolled = reader.IsDBNull(5) ? 0 : reader.GetInt32(5); // StudentsEnrolled

                            string daysOfWeek = reader.IsDBNull(6) ? string.Empty : reader.GetString(6); // DaysOfWeek
                            string prerequisites = reader.IsDBNull(7) ? string.Empty : reader.GetString(7); // Prerequisites

                            // Add course to the list
                            courses.Add(new Course(
                                courseId,
                                courseName,
                                courseSemester,
                                credits,
                                seatsAvailable,
                                studentsEnrolled,
                                daysOfWeek,
                                prerequisites
                            ));
                        }
                    }
                }
            }

            return courses;
        }

        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected course from the available courses
            string selectedCourseName = courseListBox.SelectedItem.ToString();
            selectedCourse = availableCourses.FirstOrDefault(c => c.ToString() == selectedCourseName);
        }
    }
}
