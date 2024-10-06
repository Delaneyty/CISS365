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
            }
            else if (student.AccessLevel == 2) // Regular Student
            {
                registerForCourseButton.Enabled = true;
                registerForCourseButton.Visible = true;
            }
            applicationStatusLabel.Text = "Application Status: " + GetApplicationStatus(student.ApplicationId);
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


        //  method to get student courses
        //private string GetStudentCourses(int studentId)
        //{

        //}

    }
}
