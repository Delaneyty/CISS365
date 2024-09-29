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
    public partial class StudentDashboard : Form
    {
        private Student student;
        public StudentDashboard(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            if (student.AccessLevel == 1) // Applicant
            {
                applicationStatusLabel.Text = "Application Status: " + GetApplicationStatus(student.ApplicationId);
            }
            else if (student.AccessLevel == 2) // Regular Student
            {
                applicationStatusLabel.Text = "Courses: " + GetStudentCourses(student.Id);
            }
        }

        private void applicationStatusLabel_Click(object sender, EventArgs e)
        {
            
        }
        // method to get the applicationStatus
        private string GetApplicationStatus(int? applicationId)
        {
            if (applicationId == null)
            {
                return "No application";
            }

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.customConnString))
            {
                connection.Open();
                string query = "SELECT Status FROM users.Application WHERE ApplicationId = @ApplicationId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationId", applicationId);

                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : "Unknown";
                }
            }
        }


        //  method to get student courses
        private string GetStudentCourses(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.customConnString))
            {
                connection.Open();
                string query = "SELECT c.CourseName FROM users.StudentCourses sc " +
                               "INNER JOIN users.Courses c ON sc.CourseId = c.CourseId " +
                               "WHERE sc.StudentId = @StudentId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        StringBuilder courses = new StringBuilder();
                        while (reader.Read())
                        {
                            courses.Append(reader["CourseName"].ToString() + ", ");
                        }

                        // Remove the last comma and space if there are courses
                        if (courses.Length > 2)
                        {
                            courses.Length -= 2;
                        }

                        return courses.Length > 0 ? courses.ToString() : "No courses found";
                    }
                }
            }
        }

    }
}
