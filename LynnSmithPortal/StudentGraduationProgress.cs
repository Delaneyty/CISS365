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
    public partial class StudentGraduationProgress : Form
    {
        private Student student;
        public StudentGraduationProgress(Student student)
        {
            InitializeComponent();
            this.student = student;     //Retrieve student object data
        }

        private void StudentGraduationProgress_Load(object sender, EventArgs e)
        {
            //Get data
            using SqlConnection conn = new SqlConnection(Properties.Settings.Default.customConnString);
            using SqlDataAdapter adapter = new("SELECT StudentId, CourseId, CourseName, Credits CompletionDate, Grade " +
                "FROM users.StudentCourses " +
                "JOIN users.Courses ON users.Courses.CourseId = users.CompletedCourses.CourseId" +
                "WHERE StudentId = student.studentId", conn);

            //Fill data table
            DataTable courseTable = new();
            adapter.Fill(courseTable);

            //Check for success
            if (courseTable.Rows.Count < 1) //Data not found
            {
                coursesTakenListBox.Items.Clear();
                coursesTakenListBox.Items.Add("Database Error, please try again");
            }
            else //Data found
            {
                int earnedCredits = 0;

                //Populate listbox with course data, and tally valid completed credits:
                foreach (DataRow r in courseTable.Rows)
                {
                    //Add item to listbox
                    string display = "Course ID: " + r["CourseId"].ToString() + " Course Name: " + r["CourseName"].ToString() + " Completion Date: " + r["CompletionDate"].ToString() + " Grade: " + r["Grade"].ToString();
                    coursesTakenListBox.Items.Add(display);

                    //Add to total credits
                    String grade = r["Grade"].ToString();
                    if (grade == "A" || grade == "B" || grade == "C")
                    {
                        earnedCredits += int.Parse(r["Credits"].ToString());
                    } //else: Grade below a C, which does not count towards graduation requirements
                }

                //Display label data:
                creditsCompletedLabel.Text = earnedCredits.ToString();
                creditsRemainingLabel.Text = (120 - earnedCredits).ToString();
            } //End if-else
        } //End form load event handler

        //Close form button:
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
