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
            SuspendLayout();
            // 
            // viewApplicantsListBox
            // 
            viewApplicantsListBox.FormattingEnabled = true;
            viewApplicantsListBox.ItemHeight = 41;
            viewApplicantsListBox.Location = new Point(37, 115);
            viewApplicantsListBox.Margin = new Padding(5, 5, 5, 5);
            viewApplicantsListBox.Name = "viewApplicantsListBox";
            viewApplicantsListBox.Size = new Size(1515, 373);
            viewApplicantsListBox.TabIndex = 0;
            viewApplicantsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 48);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 62);
            label1.TabIndex = 1;
            label1.Text = "Applicants:";
            // 
            // viewApplicantButton
            // 
            viewApplicantButton.Location = new Point(1676, 331);
            viewApplicantButton.Margin = new Padding(5, 5, 5, 5);
            viewApplicantButton.Name = "viewApplicantButton";
            viewApplicantButton.Size = new Size(462, 56);
            viewApplicantButton.TabIndex = 2;
            viewApplicantButton.Text = "view application";
            viewApplicantButton.UseVisualStyleBackColor = true;
            viewApplicantButton.Click += viewApplicantButton_Click;
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 41;
            studentListBox.Location = new Point(48, 605);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(640, 414);
            studentListBox.TabIndex = 3;
            studentListBox.SelectedIndexChanged += studentListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 528);
            label2.Name = "label2";
            label2.Size = new Size(259, 72);
            label2.TabIndex = 4;
            label2.Text = "Students:";
            // 
            // setAbsentButton
            // 
            setAbsentButton.Location = new Point(1681, 687);
            setAbsentButton.Name = "setAbsentButton";
            setAbsentButton.Size = new Size(462, 57);
            setAbsentButton.TabIndex = 5;
            setAbsentButton.Text = "set absent";
            setAbsentButton.UseVisualStyleBackColor = true;
            setAbsentButton.Click += setAbsentButton_Click;
            // 
            // coursesListBox
            // 
            coursesListBox.FormattingEnabled = true;
            coursesListBox.ItemHeight = 41;
            coursesListBox.Location = new Point(797, 605);
            coursesListBox.Margin = new Padding(5, 5, 5, 5);
            coursesListBox.Name = "coursesListBox";
            coursesListBox.Size = new Size(755, 414);
            coursesListBox.TabIndex = 6;
            coursesListBox.SelectedIndexChanged += coursesListBox_SelectedIndexChanged;
            // 
            // coursesTitleLabel
            // 
            coursesTitleLabel.AutoSize = true;
            coursesTitleLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coursesTitleLabel.Location = new Point(797, 526);
            coursesTitleLabel.Margin = new Padding(5, 0, 5, 0);
            coursesTitleLabel.Name = "coursesTitleLabel";
            coursesTitleLabel.Size = new Size(445, 72);
            coursesTitleLabel.TabIndex = 7;
            coursesTitleLabel.Text = "enrolled courses:";
            coursesTitleLabel.Click += coursesTitleLabel_Click;
            // 
            // dateAbsentTextBox1
            // 
            dateAbsentTextBox1.Location = new Point(1681, 605);
            dateAbsentTextBox1.Margin = new Padding(5, 5, 5, 5);
            dateAbsentTextBox1.Name = "dateAbsentTextBox1";
            dateAbsentTextBox1.Size = new Size(460, 47);
            dateAbsentTextBox1.TabIndex = 8;
            dateAbsentTextBox1.TextChanged += dateAbsentTextBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1681, 561);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(457, 41);
            label4.TabIndex = 9;
            label4.Text = "enter date absent  (yyyy-mm-dd)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(1877, 794);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 41);
            label5.TabIndex = 10;
            label5.Text = "or";
            // 
            // enterNewGradeTextField
            // 
            enterNewGradeTextField.Location = new Point(1685, 881);
            enterNewGradeTextField.Margin = new Padding(5, 5, 5, 5);
            enterNewGradeTextField.Name = "enterNewGradeTextField";
            enterNewGradeTextField.PlaceholderText = "Enter New Grade";
            enterNewGradeTextField.Size = new Size(460, 47);
            enterNewGradeTextField.TabIndex = 11;
            enterNewGradeTextField.TextChanged += enterNewGradeTextField_TextChanged;
            // 
            // setGradeButton
            // 
            setGradeButton.Location = new Point(1681, 966);
            setGradeButton.Margin = new Padding(5, 5, 5, 5);
            setGradeButton.Name = "setGradeButton";
            setGradeButton.Size = new Size(462, 56);
            setGradeButton.TabIndex = 12;
            setGradeButton.Text = "change grade";
            setGradeButton.UseVisualStyleBackColor = true;
            setGradeButton.Click += setGradeButton_Click;
            // 
            // enrolledCoursesRadioButton
            // 
            enrolledCoursesRadioButton.AutoSize = true;
            enrolledCoursesRadioButton.Location = new Point(797, 1058);
            enrolledCoursesRadioButton.Margin = new Padding(5, 5, 5, 5);
            enrolledCoursesRadioButton.Name = "enrolledCoursesRadioButton";
            enrolledCoursesRadioButton.Size = new Size(351, 45);
            enrolledCoursesRadioButton.TabIndex = 13;
            enrolledCoursesRadioButton.TabStop = true;
            enrolledCoursesRadioButton.Text = "show enrolled courses";
            enrolledCoursesRadioButton.UseVisualStyleBackColor = true;
            enrolledCoursesRadioButton.CheckedChanged += enrolledCoursesRadioButton_CheckedChanged;
            // 
            // completedCoursesRadioButton
            // 
            completedCoursesRadioButton.AutoSize = true;
            completedCoursesRadioButton.Location = new Point(1205, 1058);
            completedCoursesRadioButton.Margin = new Padding(5, 5, 5, 5);
            completedCoursesRadioButton.Name = "completedCoursesRadioButton";
            completedCoursesRadioButton.Size = new Size(385, 45);
            completedCoursesRadioButton.TabIndex = 14;
            completedCoursesRadioButton.TabStop = true;
            completedCoursesRadioButton.Text = "show completed courses";
            completedCoursesRadioButton.UseVisualStyleBackColor = true;
            completedCoursesRadioButton.CheckedChanged += completedCoursesRadioButton_CheckedChanged;
            // 
            // viewEnrollmentButton
            // 
            viewEnrollmentButton.Location = new Point(1676, 139);
            viewEnrollmentButton.Name = "viewEnrollmentButton";
            viewEnrollmentButton.Size = new Size(462, 58);
            viewEnrollmentButton.TabIndex = 15;
            viewEnrollmentButton.Text = "view enrollment page";
            viewEnrollmentButton.UseVisualStyleBackColor = true;
            viewEnrollmentButton.Click += viewEnrollmentButton_Click;
            // 
            // FacultyDashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(2244, 1576);
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
    }
}