namespace LynnSmithPortal
{
    partial class ViewStudentsBySemester
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
            springRadioButton = new RadioButton();
            fallRadioButton = new RadioButton();
            studentsListBox = new ListBox();
            label1 = new Label();
            numberStudentsEnrolledLabel = new Label();
            SuspendLayout();
            // 
            // springRadioButton
            // 
            springRadioButton.AutoSize = true;
            springRadioButton.Location = new Point(70, 70);
            springRadioButton.Name = "springRadioButton";
            springRadioButton.Size = new Size(141, 45);
            springRadioButton.TabIndex = 0;
            springRadioButton.TabStop = true;
            springRadioButton.Text = "Spring";
            springRadioButton.UseVisualStyleBackColor = true;
            springRadioButton.CheckedChanged += springRadioButton_CheckedChanged;
            // 
            // fallRadioButton
            // 
            fallRadioButton.AutoSize = true;
            fallRadioButton.Location = new Point(338, 70);
            fallRadioButton.Name = "fallRadioButton";
            fallRadioButton.Size = new Size(98, 45);
            fallRadioButton.TabIndex = 1;
            fallRadioButton.TabStop = true;
            fallRadioButton.Text = "Fall";
            fallRadioButton.UseVisualStyleBackColor = true;
            fallRadioButton.CheckedChanged += fallRadioButton_CheckedChanged;
            // 
            // studentsListBox
            // 
            studentsListBox.FormattingEnabled = true;
            studentsListBox.ItemHeight = 41;
            studentsListBox.Location = new Point(27, 141);
            studentsListBox.Name = "studentsListBox";
            studentsListBox.Size = new Size(867, 783);
            studentsListBox.TabIndex = 2;
            studentsListBox.SelectedIndexChanged += studentsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(970, 141);
            label1.Name = "label1";
            label1.Size = new Size(311, 41);
            label1.TabIndex = 3;
            label1.Text = "# of Students Enrolled";
            // 
            // numberStudentsEnrolledLabel
            // 
            numberStudentsEnrolledLabel.AutoSize = true;
            numberStudentsEnrolledLabel.Location = new Point(982, 214);
            numberStudentsEnrolledLabel.Name = "numberStudentsEnrolledLabel";
            numberStudentsEnrolledLabel.Size = new Size(97, 41);
            numberStudentsEnrolledLabel.TabIndex = 4;
            numberStudentsEnrolledLabel.Text = "label2";
            numberStudentsEnrolledLabel.Click += numberStudentsEnrolledLabel_Click;
            // 
            // ViewStudentsBySemester
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(2527, 978);
            Controls.Add(numberStudentsEnrolledLabel);
            Controls.Add(label1);
            Controls.Add(studentsListBox);
            Controls.Add(fallRadioButton);
            Controls.Add(springRadioButton);
            Name = "ViewStudentsBySemester";
            Text = "View Enrolled Students";
            Load += ViewStudentsBySemester_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton springRadioButton;
        private RadioButton fallRadioButton;
        private ListBox studentsListBox;
        private Label label1;
        private Label numberStudentsEnrolledLabel;
    }
}