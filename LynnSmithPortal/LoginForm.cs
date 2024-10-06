using System;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace LynnSmithPortal
{
    public partial class LoginForm : Form
    {
        private int accessLevel;
        private bool applicationComplete;
        private int applicationId;
        public LoginForm(int accessLevel, bool applicationComplete, int applicationId)
        {
            InitializeComponent();
            this.accessLevel = accessLevel;
            this.applicationComplete = applicationComplete;
            this.applicationId = applicationId;
            SetPageTitle();
        }
        string connectionString = Properties.Settings.Default.customConnString;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccountlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (accessLevel > 3 || applicationComplete) //either faculty/admin or they filled out an application
            {
                if (!applicationComplete)
                {
                    applicationId = -1;
                }
                //send the user to a create account page
                CreateAccount caForm = new CreateAccount(accessLevel, applicationId);
                caForm.ShowDialog();
            } else
            { //they are a "new" student, so they must fill out an application first
                FillableApplication faForm = new FillableApplication();
                faForm.ShowDialog();
            }
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextField.Text;
            Student student = GetStudentData(email, password);

            if (student != null)
            {
                MessageBox.Show("Login successful!");

                // Navigate to the Student Dashboard and pass the student object
                StudentDashboard dashboard = new StudentDashboard(student);
                dashboard.Show();
                this.Hide(); // Optionally hide or close the login form
            }
            else
            {
                MessageBox.Show("You can only log in as student atm, admin and faculty not implemented yet -Ty.");
                MessageBox.Show("Invalid email or password.");
            }
        }

        // Method to retrieve student data from the database
        private Student GetStudentData(string email, string password)
        {
            string hashedPassword = HashPassword(password);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.customConnString))
            {
                connection.Open();
                string query = "SELECT Id, [Name], Email, AccessLevel, EnrollmentDate, Major, ApplicationId FROM users.Student WHERE Email = @Email AND HashedPassword = @HashedPassword";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@HashedPassword", hashedPassword);

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


        
        // Method to hash the password
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        // Method to set the page title based on the access level
        private void SetPageTitle()
        {
            switch (accessLevel)
            {
                case 1:
                    PageTitle.Text = "Student Portal";
                    break;
                case 2:
                    PageTitle.Text = "Student Portal";
                    break;
                case 3:
                    PageTitle.Text = "Faculty Portal";
                    break;
                case 4:
                    PageTitle.Text = "Admin Portal";
                    break;
                default:
                    PageTitle.Text = "Lynn Smith University Portal"; // Default for other or unknown roles
                    break;
            }

            if (applicationComplete)
            {
                createAccountlinkLabel.Text = "Create Account";
            } else
            {
                createAccountlinkLabel.Text = "Fill out application";
            }
        }
    }
}
