using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
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
    public partial class CreateAccount : Form
    {
        private int accessLevel;
        private int applicationId;
        public CreateAccount(int accessLevel, int applicationId)
        {
            InitializeComponent();
            this.accessLevel = accessLevel;
            this.applicationId = applicationId;
        }
        //Note: All new users who are not admin, or faculty, will be created as applicant.
        //Once the application is approved, the user's accessLevel will change from: 1 (applicant) to 2 (student)

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            SetMajorOrDepartmentTextBox();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void majorOrDepartmentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetMajorOrDepartmentTextBox()
        {
            if (accessLevel == 1) // Applicant
            {
                majorOrDepartmentTextBox.PlaceholderText = "Desired Major";
            }
            else if (accessLevel == 3) // Faculty
            {
                majorOrDepartmentTextBox.PlaceholderText = "Department";
            }
            else if (accessLevel == 4) // Admin
            {
                majorOrDepartmentTextBox.Visible = false; // Hide for Admins
                createAccountButton.Location = new Point(createAccountButton.Location.X, createAccountButton.Location.Y - 100);


            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            // Collect input from the form
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string majorOrDepartment = majorOrDepartmentTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            // Hash the password
            string hashedPassword = HashPassword(password);

            // Insert the user data into the appropriate table based on the access level
            if (accessLevel == 1) // Applicant
            {
                SaveToDatabase("Student", name, email, hashedPassword, 1, majorOrDepartment); // 1 = applicant
            }
            else if (accessLevel == 3) // Faculty
            {
                SaveToDatabase("Faculty", name, email, hashedPassword, 3, majorOrDepartment); // 3 = faculty
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

        // Method to save data to the database
        private void SaveToDatabase(string table, string name, string email, string hashedPassword, int accessLevel, string majorOrDepartment)
        {
            string connectionString = Properties.Settings.Default.customConnString;
            DateTime now = DateTime.Now; // Get the current date/time
            int newStudentId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "";

                if (table == "Student")
                {
                    // Insert new applicant (student with AccessLevel 1 or 2) with EnrollmentDate
                    query = "INSERT INTO users.Student (Name, Email, HashedPassword, AccessLevel, Major, EnrollmentDate, ApplicationId) " +
                            "OUTPUT INSERTED.Id " +  // Get the inserted student's Id
                            "VALUES (@Name, @Email, @HashedPassword, @AccessLevel, @MajorOrDepartment, @EnrollmentDate, @ApplicationId)";
                }
                else if (table == "Faculty")
                {
                    // Insert new faculty with HireDate
                    query = "INSERT INTO users.Faculty (Name, Email, HashedPassword, AccessLevel, Department, HireDate) " +
                            "VALUES (@Name, @Email, @HashedPassword, @AccessLevel, @MajorOrDepartment, @HireDate)";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                    command.Parameters.AddWithValue("@AccessLevel", accessLevel);
                    command.Parameters.AddWithValue("@MajorOrDepartment", majorOrDepartment);

                    if (table == "Student")
                    {
                        command.Parameters.AddWithValue("@EnrollmentDate", now); // Add current date for EnrollmentDate
                        command.Parameters.AddWithValue("@ApplicationId", applicationId);

                        // Execute and retrieve the newly inserted studentId
                        newStudentId = (int)command.ExecuteScalar();
                    }
                    else if (table == "Faculty")
                    {
                        command.Parameters.AddWithValue("@HireDate", now); // Add current date for HireDate
                        command.ExecuteNonQuery();
                    }

                    if (newStudentId > 0)
                    {
                        // Insert sample completed courses for the new student
                        InsertSampleCompletedCourses(newStudentId);

                        MessageBox.Show("Account created successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error creating account.");
                    }
                }
            }
        }

        private void InsertSampleCompletedCourses(int studentId)
        {
            string connectionString = Properties.Settings.Default.customConnString;

            // Sample data for completed courses
            var completedCourses = new List<(int courseId, string completionDate, string grade)>
            {
                (1, "2023-05-15", "A"),   // Example: Introduction to Computer Science
                (2, "2023-06-10", "B+"),  // Example: Data Structures
                (3, "2022-12-20", "A-")   // Example: Introduction to Psychology
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (var course in completedCourses)
                {
                    string query = "INSERT INTO users.CompletedCourses (StudentId, CourseId, CompletionDate, Grade) " +
                                   "VALUES (@StudentId, @CourseId, @CompletionDate, @Grade)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        command.Parameters.AddWithValue("@CourseId", course.courseId);
                        command.Parameters.AddWithValue("@CompletionDate", course.completionDate);
                        command.Parameters.AddWithValue("@Grade", course.grade);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }


    }
}
