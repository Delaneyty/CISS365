using System;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace LynnSmithPortal
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextField.Text;

            if (ValidateStudentLogin(email, password))
            {
                MessageBox.Show("Login successful!");
                // Navigate to the student dashboard or another page
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }


        // Method to validate the student login
        private bool ValidateStudentLogin(string email, string password)
        {
            string hashedPassword = HashPassword(password);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.customConnString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM users.Student WHERE Email = @Email AND HashedPassword = @HashedPassword";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@HashedPassword", hashedPassword);

                    int result = (int)command.ExecuteScalar();
                    return result == 1; // Return true if a match is found
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



    }
}
