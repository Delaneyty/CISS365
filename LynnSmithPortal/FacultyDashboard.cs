using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LynnSmithPortal
{
    public partial class FacultyDashboard : Form
    {
        private Faculty faculty;
        public FacultyDashboard(Faculty faculty)
        {
            InitializeComponent();
            this.faculty = faculty;
        }

        private void FacultyDashboard_Load(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.customConnString;
            string query = "SELECT [Name], Email FROM users.Student WHERE AccessLevel = 1";
            // Clear any existing items in the list box
            viewApplicantsListBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Assuming you want to display both the Name and Email in the list box
                        string applicantInfo = $"{reader["Name"]} - {reader["Email"]}";
                        viewApplicantsListBox.Items.Add(applicantInfo);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //named viewApplicantsListBox (changed the name after it was initialized)

        }

        private void viewApplicantButton_Click(object sender, EventArgs e)
        {
            // Check if an applicant is selected
            if (viewApplicantsListBox.SelectedItem != null)
            {
                // Get the selected applicant's info (e.g., "Jane Doe - jane.doe@example.com")
                string selectedApplicantInfo = viewApplicantsListBox.SelectedItem.ToString();

                // Extract the student's email or ID (assuming email is the unique identifier)
                string email = selectedApplicantInfo.Split('-')[1].Trim(); // Get the email part

                // Retrieve student data based on the email
                Student selectedStudent = GetStudentByEmail(email);

                if (selectedStudent != null)
                {
                    // Open FacultyApplicationViewer and pass the selected student
                    FacultyApplicationViewer applicationViewer = new FacultyApplicationViewer(selectedStudent);
                    applicationViewer.Show();
                }
                else
                {
                    MessageBox.Show("Error: Could not retrieve student data.");
                }
            }
            else
            {
                MessageBox.Show("Please select an applicant.");
            }
        }

        private Student GetStudentByEmail(string email)
        {
            string connectionString = Properties.Settings.Default.customConnString;
            string query = "SELECT Id, [Name], Email, AccessLevel, EnrollmentDate, Major, ApplicationId FROM users.Student WHERE Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Email = reader.GetString(2),
                                AccessLevel = reader.GetInt32(3),
                                EnrollmentDate = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                                Major = reader.IsDBNull(5) ? null : reader.GetString(5),
                                ApplicationId = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6)
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }





    }
}
