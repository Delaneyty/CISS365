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
    public partial class FacultyApplicationViewer : Form
    {
        private Student student;
        public FacultyApplicationViewer(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void downloadEssayLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (student.ApplicationId != null)
            {
                StudentApplication application = GetApplicationData(student.ApplicationId.Value);

                if (application != null && application.EssayFile != null)
                {
                    // Use SaveFileDialog to let the user save the file
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = application.EssayFileName;
                    saveFileDialog.Filter = $"{application.EssayFileType}|*.{application.EssayFileType.Split('/')[1]}"; // e.g., application/pdf becomes *.pdf

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Save the essay file to the selected location
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName, application.EssayFile);
                        MessageBox.Show("Essay downloaded successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("No essay available for download.");
                }
            }
        }

        private void desiredMajorLabel_Click(object sender, EventArgs e)
        {

        }

        private void FacultyApplicationViewer_Load(object sender, EventArgs e)
        {
            DisplayStudentDetails();
        }

        private void commentslabel_Click(object sender, EventArgs e)
        {

        }

        private void referencesLabel_Click(object sender, EventArgs e)
        {

        }

        private void applicantNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            UpdateApplicationStatus(student.ApplicationId.Value, "Accepted");
            UpdateStudentAccessLevel(student.Id, 2); // Set AccessLevel to 2 (Real Student)

            MessageBox.Show("Application approved.");
            this.Close(); // Optionally close the form after approval

        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            UpdateApplicationStatus(student.ApplicationId.Value, "Rejected");

            MessageBox.Show("Application rejected.");
            this.Close(); // Optionally close the form after rejection
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void DisplayStudentDetails()
        {
            // Display student information
            applicantNameLabel.Text = student.Name;
            emailLabel.Text = student.Email;

            // Retrieve and display the student's application data
            if (student.ApplicationId != null)
            {
                StudentApplication application = GetApplicationData(student.ApplicationId.Value);

                if (application != null)
                {
                    desiredMajorLabel.Text = application.DesiredMajor;
                    commentslabel.Text = application.Comments;
                    referencesLabel.Text = application.References;

                    // Enable download link if essay exists
                    if (application.EssayFile != null && application.EssayFile.Length > 0)
                    {
                        downloadEssayLinkLabel.Enabled = true;
                    }
                }
            }
        }


        private void UpdateApplicationStatus(int applicationId, string status)
        {
            string connectionString = Properties.Settings.Default.customConnString;
            string query = "UPDATE users.[Application] SET Status = @Status WHERE ApplicationId = @ApplicationId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ApplicationId", applicationId);

                    command.ExecuteNonQuery();
                }
            }
        }
        private void UpdateStudentAccessLevel(int studentId, int accessLevel)
        {
            string connectionString = Properties.Settings.Default.customConnString;
            string query = "UPDATE users.Student SET AccessLevel = @AccessLevel WHERE Id = @StudentId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccessLevel", accessLevel);
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    command.ExecuteNonQuery();
                }
            }
        }


        private StudentApplication GetApplicationData(int applicationId)
        {
            string connectionString = Properties.Settings.Default.customConnString;
            string query = "SELECT ApplicationId, ApplicationDate, Status, Comments, DesiredMajor, [References], EssayFile, EssayFileName, EssayFileType FROM users.[Application] WHERE ApplicationId = @ApplicationId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationId", applicationId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new StudentApplication
                            {
                                ApplicationId = reader.GetInt32(0),
                                ApplicationDate = reader.GetDateTime(1),
                                Status = reader.GetString(2),
                                Comments = reader.IsDBNull(3) ? null : reader.GetString(3),
                                DesiredMajor = reader.IsDBNull(4) ? null : reader.GetString(4),
                                References = reader.IsDBNull(5) ? null : reader.GetString(5),
                                EssayFile = reader.IsDBNull(6) ? null : (byte[])reader["EssayFile"],
                                EssayFileName = reader.IsDBNull(7) ? null : reader.GetString(7),
                                EssayFileType = reader.IsDBNull(8) ? null : reader.GetString(8)
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
