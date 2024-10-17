using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LynnSmithPortal
{
    public partial class ViewStudentsBySemester : Form
    {
        public ViewStudentsBySemester()
        {
            InitializeComponent();
        }

        private void springRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (springRadioButton.Checked)
            {
                PopulateStudentsListBox(2); // 2 for Spring semester
            }
        }

        private void ViewStudentsBySemester_Load(object sender, EventArgs e)
        {
            fallRadioButton.Checked = true;
            PopulateStudentsListBox(1); // 1 for Fall
        }

        private void fallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fallRadioButton.Checked)
            {
                PopulateStudentsListBox(1); // 1 for Fall semester
            }
        }

        private void studentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numberStudentsEnrolledLabel_Click(object sender, EventArgs e)
        {

        }

        // Method to populate the studentsListBox based on the selected semester
        private void PopulateStudentsListBox(int semester)
        {
            string connectionString = Properties.Settings.Default.customConnString;
            string query = @"
                SELECT s.[Name], s.Email
                FROM users.Student s
                JOIN users.StudentCourses sc ON s.Id = sc.StudentId
                JOIN users.Courses c ON sc.CourseId = c.CourseId
                WHERE c.Semester = @Semester";

            studentsListBox.Items.Clear(); // Clear the list before populating

            int studentCount = 0; // Variable to keep track of the number of students

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Semester", semester);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string studentInfo = $"{reader["Name"]} - {reader["Email"]}";
                        studentsListBox.Items.Add(studentInfo);
                        studentCount++; // Increment the count for each student
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Update the label with the count of students enrolled
            numberStudentsEnrolledLabel.Text = $"{studentCount}";
        }
    
    }
}
