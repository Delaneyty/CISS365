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
            SuspendLayout();
            // 
            // applicationStatusLabel
            // 
            applicationStatusLabel.AutoSize = true;
            applicationStatusLabel.Location = new Point(48, 79);
            applicationStatusLabel.Name = "applicationStatusLabel";
            applicationStatusLabel.Size = new Size(256, 41);
            applicationStatusLabel.TabIndex = 0;
            applicationStatusLabel.Text = "Application Status";
            applicationStatusLabel.Click += applicationStatusLabel_Click;
            // 
            // registerForCourseButton
            // 
            registerForCourseButton.Location = new Point(48, 189);
            registerForCourseButton.Name = "registerForCourseButton";
            registerForCourseButton.Size = new Size(200, 126);
            registerForCourseButton.TabIndex = 1;
            registerForCourseButton.Text = "Register for Courses";
            registerForCourseButton.UseVisualStyleBackColor = true;
            registerForCourseButton.Click += registerForCourseButton_Click;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(2027, 1018);
            Controls.Add(registerForCourseButton);
            Controls.Add(applicationStatusLabel);
            Name = "StudentDashboard";
            Text = "Student Dashboard";
            Load += StudentDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label applicationStatusLabel;
        private Button registerForCourseButton;
    }
}