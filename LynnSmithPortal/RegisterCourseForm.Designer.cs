namespace LynnSmithPortal
{
    partial class RegisterCourseForm
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
            fallRadioButton = new RadioButton();
            springRadioButton = new RadioButton();
            label1 = new Label();
            registerCourseButton = new Button();
            courseListBox = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // fallRadioButton
            // 
            fallRadioButton.AutoSize = true;
            fallRadioButton.Location = new Point(22, 105);
            fallRadioButton.Name = "fallRadioButton";
            fallRadioButton.Size = new Size(240, 45);
            fallRadioButton.TabIndex = 0;
            fallRadioButton.TabStop = true;
            fallRadioButton.Text = "Fall - 16 Week";
            fallRadioButton.UseVisualStyleBackColor = true;
            fallRadioButton.CheckedChanged += fallRadioButton_CheckedChanged;
            // 
            // springRadioButton
            // 
            springRadioButton.AutoSize = true;
            springRadioButton.Location = new Point(344, 105);
            springRadioButton.Name = "springRadioButton";
            springRadioButton.Size = new Size(283, 45);
            springRadioButton.TabIndex = 1;
            springRadioButton.TabStop = true;
            springRadioButton.Text = "Spring - 16 Week";
            springRadioButton.UseVisualStyleBackColor = true;
            springRadioButton.CheckedChanged += springRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.1F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(272, 72);
            label1.TabIndex = 2;
            label1.Text = "Semester:";
            // 
            // registerCourseButton
            // 
            registerCourseButton.Location = new Point(1854, 87);
            registerCourseButton.Name = "registerCourseButton";
            registerCourseButton.Size = new Size(422, 63);
            registerCourseButton.TabIndex = 3;
            registerCourseButton.Text = "Register Course";
            registerCourseButton.UseVisualStyleBackColor = true;
            registerCourseButton.Click += registerCourseButton_Click;
            // 
            // courseListBox
            // 
            courseListBox.BackColor = Color.LightSteelBlue;
            courseListBox.FormattingEnabled = true;
            courseListBox.Location = new Point(22, 343);
            courseListBox.Name = "courseListBox";
            courseListBox.Size = new Size(2254, 532);
            courseListBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(1041, 295);
            label2.Name = "label2";
            label2.Size = new Size(1225, 41);
            label2.TabIndex = 5;
            label2.Text = "Select 1 or more courses to register. (This will not show courses you are already enrolled in)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 278);
            label3.Name = "label3";
            label3.Size = new Size(410, 62);
            label3.TabIndex = 6;
            label3.Text = "Available Courses:";
            // 
            // RegisterCourseForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(2315, 927);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(courseListBox);
            Controls.Add(registerCourseButton);
            Controls.Add(label1);
            Controls.Add(springRadioButton);
            Controls.Add(fallRadioButton);
            Name = "RegisterCourseForm";
            Text = "Register for a course";
            Load += RegisterCourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton fallRadioButton;
        private RadioButton springRadioButton;
        private Label label1;
        private Button registerCourseButton;
        private CheckedListBox courseListBox;
        private Label label2;
        private Label label3;
    }
}