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
    public partial class FillableApplication : Form
    {
        private byte[] essayFileData;
        private string essayFileName;
        private string essayFileType;
        public FillableApplication()
        {
            InitializeComponent();
        }

        private void FillableApplication_Load(object sender, EventArgs e)
        {

        }

        //comments text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void fileName_Click(object sender, EventArgs e)
        {

        }

        private void uploadEssay_Click(object sender, EventArgs e)
        {
            // Open the file dialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the allowed file types
                openFileDialog.Filter = "Word Documents|*.doc;*.docx|PDF Files|*.pdf|Text Files|*.txt";

                // Show the file dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file's name and type
                    essayFileName = Path.GetFileName(openFileDialog.FileName);
                    essayFileType = GetMimeType(openFileDialog.FileName);

                    // Read the file data into a byte array
                    essayFileData = File.ReadAllBytes(openFileDialog.FileName);

                    // Set the file name label to display the selected file's name
                    fileName.Text = essayFileName;

                    MessageBox.Show("File uploaded successfully!");
                }
            }
        }

        // Method to determine the file's MIME type based on its extension
        private string GetMimeType(string fileName)
        {
            string extension = Path.GetExtension(fileName).ToLower();
            switch (extension)
            {
                case ".pdf": return "application/pdf";
                case ".doc": return "application/msword";
                case ".docx": return "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                case ".txt": return "text/plain";
                default: return "application/octet-stream"; // Default binary stream
            }
        }

        private void desiredMajor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //references
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Collect application data
            string comments = textBox1.Text;
            string desiredMajor = desiredMajorTextBox.Text;
            string references = textBox2.Text;

            if (string.IsNullOrEmpty(desiredMajor))
            {
                MessageBox.Show("Please fill in desired major.");
                return;
            }

            if (essayFileData == null || string.IsNullOrEmpty(essayFileName))
            {
                MessageBox.Show("Please upload your essay file.");
                return;
            }

            // Save the application to the database and get the ApplicationId
            int applicationId = SaveApplicationToDatabase(comments, desiredMajor, references, essayFileData, essayFileName, essayFileType);

            if (applicationId > 0)
            {
                MessageBox.Show("Application submitted successfully!");

                LoginForm loginForm = new LoginForm(1, true, applicationId); //access level 1 (applicant) applicationComplete? (true)
                loginForm.ShowDialog();
                this.Close(); // Close the FillableApplication form
            }
            else
            {
                MessageBox.Show("Error submitting application.");
            }
        }

        // Method to save application data to the database and return the generated ApplicationId
        private int SaveApplicationToDatabase(string comments, string desiredMajor, string references, byte[] essayFileData, string essayFileName, string essayFileType)
        {
            string connectionString = Properties.Settings.Default.customConnString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO users.Application (ApplicationDate, [Status], Comments, DesiredMajor, [References], EssayFile, EssayFileName, EssayFileType) " +
                               "OUTPUT INSERTED.ApplicationId " +
                               "VALUES (@ApplicationDate, @Status, @Comments, @DesiredMajor, @References, @EssayFile, @EssayFileName, @EssayFileType)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationDate", DateTime.Now);
                    command.Parameters.AddWithValue("@Status", "Pending");
                    command.Parameters.AddWithValue("@Comments", comments);
                    command.Parameters.AddWithValue("@DesiredMajor", desiredMajor);
                    command.Parameters.AddWithValue("@References", references);
                    command.Parameters.AddWithValue("@EssayFile", essayFileData);
                    command.Parameters.AddWithValue("@EssayFileName", essayFileName);
                    command.Parameters.AddWithValue("@EssayFileType", essayFileType);

                    // Execute the insert command and get the generated ApplicationId
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // Indicate failure
                    }
                }
            }
        }

    }
}
