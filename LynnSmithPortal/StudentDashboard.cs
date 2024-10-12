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
using static System.Net.Mime.MediaTypeNames;

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
                registerForCourseButton.Enabled = false;
                registerForCourseButton.Visible = false;
                attendanceLabel.Enabled = false;
                attendanceListBox.Enabled = false;

            }
            else if (student.AccessLevel == 2) // Regular Student
            {
                registerForCourseButton.Enabled = true;
                registerForCourseButton.Visible = true;
                attendanceLabel.Enabled = true;
                attendanceListBox.Enabled = true;
            }
            applicationStatusLabel.Text = "Application Status: " + GetApplicationStatus(student.ApplicationId);

            //load absences
            LoadStudentAbsences(student.studentId);
            LoadCompletedCourses(student.studentId);
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

        private void registerForCourseButton_Click(object sender, EventArgs e)
        {
            RegisterCourseForm rcForm = new RegisterCourseForm(student);
            rcForm.ShowDialog();
        }

        private void viewGradesAttendance_Click(object sender, EventArgs e)
        {

        }

        private void attendanceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void attendanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoadStudentAbsences(int studentId)
        {
            attendanceListBox.Items.Clear(); // Clear the ListBox before adding new items

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.customConnString))
            {
                connection.Open();
                string query = @"
                SELECT c.CourseName, a.AbsenceDate
                FROM users.Absences a
                JOIN users.Courses c ON a.CourseId = c.CourseId
                WHERE a.StudentId = @StudentId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string courseName = reader["CourseName"].ToString();
                        DateTime absenceDate = (DateTime)reader["AbsenceDate"];
                        string displayText = $"{courseName} - {absenceDate.ToString("yyyy-MM-dd")}";

                        attendanceListBox.Items.Add(displayText);
                    }
                }
            }
        }
        private void LoadCompletedCourses(int studentId)
        {
            gradesListBox.Items.Clear(); // Clear the ListBox before adding new items

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.customConnString))
            {
                connection.Open();
                string query = @"
                SELECT c.CourseName, cc.Grade
                FROM users.CompletedCourses cc
                JOIN users.Courses c ON cc.CourseId = c.CourseId
                WHERE cc.StudentId = @StudentId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string courseName = reader["CourseName"].ToString();
                        string grade = reader["Grade"].ToString();
                        string displayText = $"{courseName} - Grade: {grade}";

                        gradesListBox.Items.Add(displayText);
                    }
                }
            }
        }

        private void gradesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //  method to get student courses
        //private string GetStudentCourses(int studentId)
        //{

        //}

    }
}
