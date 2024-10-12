namespace LynnSmithPortal
{
    partial class StudentDashboard
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
            applicationStatusLabel = new Label();
            registerForCourseButton = new Button();
            attendanceLabel = new Label();
            attendanceListBox = new ListBox();
            SuspendLayout();
            // 
            // applicationStatusLabel
            // 
            applicationStatusLabel.AutoSize = true;
            applicationStatusLabel.Location = new Point(28, 48);
            applicationStatusLabel.Margin = new Padding(2, 0, 2, 0);
            applicationStatusLabel.Name = "applicationStatusLabel";
            applicationStatusLabel.Size = new Size(155, 25);
            applicationStatusLabel.TabIndex = 0;
            applicationStatusLabel.Text = "Application Status";
            applicationStatusLabel.Click += applicationStatusLabel_Click;
            // 
            // registerForCourseButton
            // 
            registerForCourseButton.Location = new Point(28, 115);
            registerForCourseButton.Margin = new Padding(2, 2, 2, 2);
            registerForCourseButton.Name = "registerForCourseButton";
            registerForCourseButton.Size = new Size(118, 77);
            registerForCourseButton.TabIndex = 1;
            registerForCourseButton.Text = "Register for Courses";
            registerForCourseButton.UseVisualStyleBackColor = true;
            registerForCourseButton.Click += registerForCourseButton_Click;
            // 
            // attendanceLabel
            // 
            attendanceLabel.AutoSize = true;
            attendanceLabel.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendanceLabel.Location = new Point(794, 43);
            attendanceLabel.Margin = new Padding(2, 0, 2, 0);
            attendanceLabel.Name = "attendanceLabel";
            attendanceLabel.Size = new Size(168, 45);
            attendanceLabel.TabIndex = 2;
            attendanceLabel.Text = "Absences:";
            attendanceLabel.Click += attendanceLabel_Click;
            // 
            // attendanceListBox
            // 
            attendanceListBox.FormattingEnabled = true;
            attendanceListBox.ItemHeight = 25;
            attendanceListBox.Location = new Point(577, 104);
            attendanceListBox.Margin = new Padding(2, 2, 2, 2);
            attendanceListBox.Name = "attendanceListBox";
            attendanceListBox.Size = new Size(610, 479);
            attendanceListBox.TabIndex = 3;
            attendanceListBox.SelectedIndexChanged += attendanceListBox_SelectedIndexChanged;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1192, 621);
            Controls.Add(attendanceListBox);
            Controls.Add(attendanceLabel);
            Controls.Add(registerForCourseButton);
            Controls.Add(applicationStatusLabel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "StudentDashboard";
            Text = "Student Dashboard";
            Load += StudentDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label applicationStatusLabel;
        private Button registerForCourseButton;
        private Label attendanceLabel;
        private ListBox attendanceListBox;
    }
}