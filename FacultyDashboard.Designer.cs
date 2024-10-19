namespace LynnSmithPortal
{
    partial class FacultyDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            viewApplicantsListBox = new ListBox();
            label1 = new Label();
            viewApplicantButton = new Button();
            studentListBox = new ListBox();
            label2 = new Label();
            setAbsentButton = new Button();
            coursesListBox = new ListBox();
            coursesTitleLabel = new Label();
            dateAbsentTextBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            enterNewGradeTextField = new TextBox();
            setGradeButton = new Button();
            enrolledCoursesRadioButton = new RadioButton();
            completedCoursesRadioButton = new RadioButton();
            viewEnrollmentButton = new Button();
            GenerateReportbtn = new Button();
            trackPerformancebtn = new Button();
            SuspendLayout();
            // 
            // viewApplicantsListBox
            // 
            viewApplicantsListBox.FormattingEnabled = true;
            viewApplicantsListBox.ItemHeight = 15;
            viewApplicantsListBox.Location = new Point(15, 42);
            viewApplicantsListBox.Margin = new Padding(2);
            viewApplicantsListBox.Name = "viewApplicantsListBox";
            viewApplicantsListBox.Size = new Size(626, 139);
            viewApplicantsListBox.TabIndex = 0;
            viewApplicantsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "Applicants:";
            // 
            // viewApplicantButton
            // 
            viewApplicantButton.Location = new Point(690, 121);
            viewApplicantButton.Margin = new Padding(2);
            viewApplicantButton.Name = "viewApplicantButton";
            viewApplicantButton.Size = new Size(190, 20);
            viewApplicantButton.TabIndex = 2;
            viewApplicantButton.Text = "view application";
            viewApplicantButton.UseVisualStyleBackColor = true;
            viewApplicantButton.Click += viewApplicantButton_Click;
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 15;
            studentListBox.Location = new Point(20, 221);
            studentListBox.Margin = new Padding(1);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(266, 154);
            studentListBox.TabIndex = 3;
            studentListBox.SelectedIndexChanged += studentListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 193);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 4;
            label2.Text = "Students:";
            // 
            // setAbsentButton
            // 
            setAbsentButton.Location = new Point(692, 251);
            setAbsentButton.Margin = new Padding(1);
            setAbsentButton.Name = "setAbsentButton";
            setAbsentButton.Size = new Size(190, 21);
            setAbsentButton.TabIndex = 5;
            setAbsentButton.Text = "set absent";
            setAbsentButton.UseVisualStyleBackColor = true;
            setAbsentButton.Click += setAbsentButton_Click;
            // 
            // coursesListBox
            // 
            coursesListBox.FormattingEnabled = true;
            coursesListBox.ItemHeight = 15;
            coursesListBox.Location = new Point(328, 221);
            coursesListBox.Margin = new Padding(2);
            coursesListBox.Name = "coursesListBox";
            coursesListBox.Size = new Size(313, 154);
            coursesListBox.TabIndex = 6;
            coursesListBox.SelectedIndexChanged += coursesListBox_SelectedIndexChanged;
            // 
            // coursesTitleLabel
            // 
            coursesTitleLabel.AutoSize = true;
            coursesTitleLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coursesTitleLabel.Location = new Point(328, 192);
            coursesTitleLabel.Margin = new Padding(2, 0, 2, 0);
            coursesTitleLabel.Name = "coursesTitleLabel";
            coursesTitleLabel.Size = new Size(181, 30);
            coursesTitleLabel.TabIndex = 7;
            coursesTitleLabel.Text = "enrolled courses:";
            coursesTitleLabel.Click += coursesTitleLabel_Click;
            // 
            // dateAbsentTextBox1
            // 
            dateAbsentTextBox1.Location = new Point(692, 221);
            dateAbsentTextBox1.Margin = new Padding(2);
            dateAbsentTextBox1.Name = "dateAbsentTextBox1";
            dateAbsentTextBox1.Size = new Size(192, 23);
            dateAbsentTextBox1.TabIndex = 8;
            dateAbsentTextBox1.TextChanged += dateAbsentTextBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(692, 205);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(182, 15);
            label4.TabIndex = 9;
            label4.Text = "enter date absent  (yyyy-mm-dd)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(773, 290);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 10;
            label5.Text = "or";
            // 
            // enterNewGradeTextField
            // 
            enterNewGradeTextField.Location = new Point(694, 322);
            enterNewGradeTextField.Margin = new Padding(2);
            enterNewGradeTextField.Name = "enterNewGradeTextField";
            enterNewGradeTextField.PlaceholderText = "Enter New Grade";
            enterNewGradeTextField.Size = new Size(192, 23);
            enterNewGradeTextField.TabIndex = 11;
            enterNewGradeTextField.TextChanged += enterNewGradeTextField_TextChanged;
            // 
            // setGradeButton
            // 
            setGradeButton.Location = new Point(692, 353);
            setGradeButton.Margin = new Padding(2);
            setGradeButton.Name = "setGradeButton";
            setGradeButton.Size = new Size(190, 20);
            setGradeButton.TabIndex = 12;
            setGradeButton.Text = "change grade";
            setGradeButton.UseVisualStyleBackColor = true;
            setGradeButton.Click += setGradeButton_Click;
            // 
            // enrolledCoursesRadioButton
            // 
            enrolledCoursesRadioButton.AutoSize = true;
            enrolledCoursesRadioButton.Location = new Point(328, 387);
            enrolledCoursesRadioButton.Margin = new Padding(2);
            enrolledCoursesRadioButton.Name = "enrolledCoursesRadioButton";
            enrolledCoursesRadioButton.Size = new Size(142, 19);
            enrolledCoursesRadioButton.TabIndex = 13;
            enrolledCoursesRadioButton.TabStop = true;
            enrolledCoursesRadioButton.Text = "show enrolled courses";
            enrolledCoursesRadioButton.UseVisualStyleBackColor = true;
            enrolledCoursesRadioButton.CheckedChanged += enrolledCoursesRadioButton_CheckedChanged;
            // 
            // completedCoursesRadioButton
            // 
            completedCoursesRadioButton.AutoSize = true;
            completedCoursesRadioButton.Location = new Point(496, 387);
            completedCoursesRadioButton.Margin = new Padding(2);
            completedCoursesRadioButton.Name = "completedCoursesRadioButton";
            completedCoursesRadioButton.Size = new Size(156, 19);
            completedCoursesRadioButton.TabIndex = 14;
            completedCoursesRadioButton.TabStop = true;
            completedCoursesRadioButton.Text = "show completed courses";
            completedCoursesRadioButton.UseVisualStyleBackColor = true;
            completedCoursesRadioButton.CheckedChanged += completedCoursesRadioButton_CheckedChanged;
            // 
            // viewEnrollmentButton
            // 
            viewEnrollmentButton.Location = new Point(690, 51);
            viewEnrollmentButton.Margin = new Padding(1);
            viewEnrollmentButton.Name = "viewEnrollmentButton";
            viewEnrollmentButton.Size = new Size(190, 21);
            viewEnrollmentButton.TabIndex = 15;
            viewEnrollmentButton.Text = "view enrollment page";
            viewEnrollmentButton.UseVisualStyleBackColor = true;
            viewEnrollmentButton.Click += viewEnrollmentButton_Click;
            // 
            // GenerateReportbtn
            // 
            GenerateReportbtn.Location = new Point(20, 399);
            GenerateReportbtn.Name = "GenerateReportbtn";
            GenerateReportbtn.Size = new Size(120, 23);
            GenerateReportbtn.TabIndex = 16;
            GenerateReportbtn.Text = "Generate Report";
            GenerateReportbtn.UseVisualStyleBackColor = true;
            GenerateReportbtn.Click += GenerateReportbtn_Click;
            // 
            // trackPerformancebtn
            // 
            trackPerformancebtn.Location = new Point(166, 399);
            trackPerformancebtn.Name = "trackPerformancebtn";
            trackPerformancebtn.Size = new Size(120, 23);
            trackPerformancebtn.TabIndex = 17;
            trackPerformancebtn.Text = "Track Performance";
            trackPerformancebtn.UseVisualStyleBackColor = true;
            trackPerformancebtn.Click += trackPerformancebtn_Click;
            // 
            // FacultyDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(660, 440);
            Controls.Add(trackPerformancebtn);
            Controls.Add(GenerateReportbtn);
            Controls.Add(viewEnrollmentButton);
            Controls.Add(completedCoursesRadioButton);
            Controls.Add(enrolledCoursesRadioButton);
            Controls.Add(setGradeButton);
            Controls.Add(enterNewGradeTextField);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateAbsentTextBox1);
            Controls.Add(coursesTitleLabel);
            Controls.Add(coursesListBox);
            Controls.Add(setAbsentButton);
            Controls.Add(label2);
            Controls.Add(studentListBox);
            Controls.Add(viewApplicantButton);
            Controls.Add(label1);
            Controls.Add(viewApplicantsListBox);
            Margin = new Padding(1);
            Name = "FacultyDashboard";
            Text = "Faculty Dashboard";
            Load += FacultyDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox viewApplicantsListBox;
        private Label label1;
        private Button viewApplicantButton;
        private ListBox studentListBox;
        private Label label2;
        private Button setAbsentButton;
        private ListBox coursesListBox;
        private Label coursesTitleLabel;
        private TextBox dateAbsentTextBox1;
        private Label label4;
        private Label label5;
        private TextBox enterNewGradeTextField;
        private Button setGradeButton;
        private RadioButton enrolledCoursesRadioButton;
        private RadioButton completedCoursesRadioButton;
        private Button viewEnrollmentButton;
        private Button GenerateReportbtn;
        private Button trackPerformancebtn;
    }
}