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
            enrolledCoursesRadioButton.Checked = true;
            coursesTitleLabel.Text = "Enrolled Courses:";

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
            PopulateStudentsListBox();
        }

        // Method to populate the studentsListBox with students who have AccessLevel = 2
        private void PopulateStudentsListBox()
        {
            string connectionString = Properties.Settings.Default.customConnString;
            string query = "SELECT Id, [Name] FROM users.Student WHERE AccessLevel = 2"; // Only students with AccessLevel 2

            studentListBox.Items.Clear(); // Clear any existing items

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add student to list box (store student ID for easy reference)
                        string studentInfo = $"{reader["Id"]} - {reader["Name"]}";
                        studentListBox.Items.Add(studentInfo);
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
                                studentId = reader.GetInt32(0),
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

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentListBox.SelectedItem != null)
            {
                // Get the selected student's Id from the selected list item
                string selectedStudentInfo = studentListBox.SelectedItem.ToString();
                int selectedStudentId = int.Parse(selectedStudentInfo.Split('-')[0].Trim());

                // Populate the courses for the selected student
                PopulateCoursesListBox(selectedStudentId);
            }
        }

        // Method to populate the coursesListBox based on the selected student
        private void PopulateCoursesListBox(int studentId)
        {
            string connectionString = Properties.Settings.Default.customConnString;
            string query = "";

            // Check which radio button is selected and adjust the query accordingly
            if (enrolledCoursesRadioButton.Checked)
            {
                // Query to fetch enrolled courses from StudentCourses table
                query = @"
            SELECT c.CourseName, sc.currentGrade 
            FROM users.StudentCourses sc
            JOIN users.Courses c ON sc.CourseId = c.CourseId
            WHERE sc.StudentId = @StudentId";
            }
            else if (completedCoursesRadioButton.Checked)
            {
                // Query to fetch completed courses from CompletedCourses table
                query = @"
            SELECT c.CourseName, cc.Grade AS currentGrade 
            FROM users.CompletedCourses cc
            JOIN users.Courses c ON cc.CourseId = c.CourseId
            WHERE cc.StudentId = @StudentId";
            }

            coursesListBox.Items.Clear(); // Clear the courses list before populating

            if (!string.IsNullOrEmpty(query)) // Ensure the query is valid
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            // Get the course name and grade (handle null values for currentGrade)
                            string courseName = reader["CourseName"].ToString();
                            string currentGrade = reader["currentGrade"] != DBNull.Value ? reader["currentGrade"].ToString() : "N/A"; // Show "N/A" if the grade is null

                            // Add course name and grade to the list box
                            coursesListBox.Items.Add($"{courseName} - Grade: {currentGrade}");
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void coursesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateAbsentTextBox1_TextChanged(object sender, EventArgs e)
        {

            // Ensure that the user enters a valid date format (yyyy-mm-dd)

        }

        private void setAbsentButton_Click(object sender, EventArgs e)
        {
            // Ensure a student is selected
            if (studentListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            // Ensure a course is selected
            if (coursesListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            // Ensure the date is in the correct format
            string inputDate = dateAbsentTextBox1.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(inputDate, @"^\d{4}-\d{2}-\d{2}$"))
            {
                MessageBox.Show("Please enter the date in the format yyyy-mm-dd.");
                return;
            }

            // Parse the selected student and course
            string selectedStudentInfo = studentListBox.SelectedItem.ToString();
            int selectedStudentId = int.Parse(selectedStudentInfo.Split('-')[0].Trim());

            string selectedCourseName = coursesListBox.SelectedItem.ToString();

            // Fetch the corresponding CourseId for the selected course
            int selectedCourseId = GetCourseIdByName(selectedCourseName);

            if (selectedCourseId == -1)
            {
                MessageBox.Show("Error: Could not find the course ID.");
                return;
            }

            // Insert the absence record into the database
            string connectionString = Properties.Settings.Default.customConnString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO users.Absences (StudentId, CourseId, AbsenceDate) VALUES (@StudentId, @CourseId, @AbsenceDate)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", selectedStudentId);
                    command.Parameters.AddWithValue("@CourseId", selectedCourseId);
                    command.Parameters.AddWithValue("@AbsenceDate", inputDate);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Absence successfully recorded.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // Helper method to get CourseId based on CourseName
        private int GetCourseIdByName(string courseName)
        {
            int courseId = -1; // Initialize with an invalid ID

            string connectionString = Properties.Settings.Default.customConnString;
            string query = "SELECT CourseId FROM users.Courses WHERE CourseName = @CourseName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseName", courseName);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            courseId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching Course ID: " + ex.Message);
                    }
                }
            }

            return courseId;
        }

        private void enterNewGradeTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void setGradeButton_Click(object sender, EventArgs e)
        {
            // Validate if a student and course are selected
            if (studentListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            if (coursesListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            // Validate the grade input
            string newGrade = enterNewGradeTextField.Text.Trim();
            if (newGrade.Length < 1 || newGrade.Length > 2)
            {
                MessageBox.Show("Error: Grade must be 1 or 2 characters.");
                return;
            }

            // Parse the selected student and course
            string selectedStudentInfo = studentListBox.SelectedItem.ToString();
            int selectedStudentId = int.Parse(selectedStudentInfo.Split('-')[0].Trim());

            string selectedCourseInfo = coursesListBox.SelectedItem.ToString();
            string selectedCourseName = selectedCourseInfo.Split('-')[0].Trim(); // Get course name part

            // Fetch the corresponding CourseId for the selected course
            int selectedCourseId = GetCourseIdByName(selectedCourseName);

            if (selectedCourseId == -1)
            {
                MessageBox.Show("Error: Could not find the course ID.");
                return;
            }

            // Check if we are updating an enrolled course or a completed course
            string connectionString = Properties.Settings.Default.customConnString;
            string query = "";

            if (enrolledCoursesRadioButton.Checked)
            {
                // Update grade in StudentCourses table for enrolled students
                query = "UPDATE users.StudentCourses SET currentGrade = @Grade WHERE StudentId = @StudentId AND CourseId = @CourseId";
            }
            else if (completedCoursesRadioButton.Checked)
            {
                // Update grade in CompletedCourses table for completed courses
                query = "UPDATE users.CompletedCourses SET Grade = @Grade WHERE StudentId = @StudentId AND CourseId = @CourseId";
            }

            // Perform the update in the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Grade", newGrade);
                    command.Parameters.AddWithValue("@StudentId", selectedStudentId);
                    command.Parameters.AddWithValue("@CourseId", selectedCourseId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Grade updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error: Grade update failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // Optionally, refresh the course list to reflect the updated grade
            PopulateCoursesListBox(selectedStudentId);
        }

        private void enrolledCoursesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (enrolledCoursesRadioButton.Checked)
            {
                coursesTitleLabel.Text = "Enrolled Courses:";
                if (studentListBox.SelectedItem != null)
                {
                    // Get the selected student's Id and repopulate the courses list box
                    string selectedStudentInfo = studentListBox.SelectedItem.ToString();
                    int selectedStudentId = int.Parse(selectedStudentInfo.Split('-')[0].Trim());
                    PopulateCoursesListBox(selectedStudentId);
                }
            }
        }

        private void completedCoursesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (completedCoursesRadioButton.Checked)
            {
                coursesTitleLabel.Text = "Completed Courses:";
                if (studentListBox.SelectedItem != null)
                {
                    // Get the selected student's Id and repopulate the courses list box
                    string selectedStudentInfo = studentListBox.SelectedItem.ToString();
                    int selectedStudentId = int.Parse(selectedStudentInfo.Split('-')[0].Trim());
                    PopulateCoursesListBox(selectedStudentId);
                }
            }
        }

        private void coursesTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void viewEnrollmentButton_Click(object sender, EventArgs e)
        {
            ViewStudentsBySemester viewStudentsBySemester = new ViewStudentsBySemester();
            viewStudentsBySemester.Show();
        }
    }
}
