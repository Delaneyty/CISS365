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
            label3 = new Label();
            dateAbsentTextBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // viewApplicantsListBox
            // 
            viewApplicantsListBox.FormattingEnabled = true;
            viewApplicantsListBox.ItemHeight = 25;
            viewApplicantsListBox.Location = new Point(22, 70);
            viewApplicantsListBox.Name = "viewApplicantsListBox";
            viewApplicantsListBox.Size = new Size(893, 229);
            viewApplicantsListBox.TabIndex = 0;
            viewApplicantsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(157, 38);
            label1.TabIndex = 1;
            label1.Text = "Applicants:";
            // 
            // viewApplicantButton
            // 
            viewApplicantButton.Location = new Point(989, 148);
            viewApplicantButton.Name = "viewApplicantButton";
            viewApplicantButton.Size = new Size(272, 34);
            viewApplicantButton.TabIndex = 2;
            viewApplicantButton.Text = "view application";
            viewApplicantButton.UseVisualStyleBackColor = true;
            viewApplicantButton.Click += viewApplicantButton_Click;
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 25;
            studentListBox.Location = new Point(28, 369);
            studentListBox.Margin = new Padding(2);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(378, 254);
            studentListBox.TabIndex = 3;
            studentListBox.SelectedIndexChanged += studentListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 322);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 45);
            label2.TabIndex = 4;
            label2.Text = "Students:";
            // 
            // setAbsentButton
            // 
            setAbsentButton.Location = new Point(989, 484);
            setAbsentButton.Margin = new Padding(2);
            setAbsentButton.Name = "setAbsentButton";
            setAbsentButton.Size = new Size(272, 35);
            setAbsentButton.TabIndex = 5;
            setAbsentButton.Text = "set absent";
            setAbsentButton.UseVisualStyleBackColor = true;
            setAbsentButton.Click += setAbsentButton_Click;
            // 
            // coursesListBox
            // 
            coursesListBox.FormattingEnabled = true;
            coursesListBox.ItemHeight = 25;
            coursesListBox.Location = new Point(469, 369);
            coursesListBox.Name = "coursesListBox";
            coursesListBox.Size = new Size(446, 254);
            coursesListBox.TabIndex = 6;
            coursesListBox.SelectedIndexChanged += coursesListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(469, 321);
            label3.Name = "label3";
            label3.Size = new Size(266, 45);
            label3.TabIndex = 7;
            label3.Text = "enrolled courses:";
            // 
            // dateAbsentTextBox1
            // 
            dateAbsentTextBox1.Location = new Point(989, 385);
            dateAbsentTextBox1.Name = "dateAbsentTextBox1";
            dateAbsentTextBox1.Size = new Size(272, 31);
            dateAbsentTextBox1.TabIndex = 8;
            dateAbsentTextBox1.TextChanged += dateAbsentTextBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(989, 342);
            label4.Name = "label4";
            label4.Size = new Size(274, 25);
            label4.TabIndex = 9;
            label4.Text = "enter date absent  (yyyy-mm-dd)";
            // 
            // FacultyDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1320, 748);
            Controls.Add(label4);
            Controls.Add(dateAbsentTextBox1);
            Controls.Add(label3);
            Controls.Add(coursesListBox);
            Controls.Add(setAbsentButton);
            Controls.Add(label2);
            Controls.Add(studentListBox);
            Controls.Add(viewApplicantButton);
            Controls.Add(label1);
            Controls.Add(viewApplicantsListBox);
            Margin = new Padding(2);
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
        private Label label3;
        private TextBox dateAbsentTextBox1;
        private Label label4;
    }
}