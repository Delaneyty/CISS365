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
            SuspendLayout();
            // 
            // viewApplicantsListBox
            // 
            viewApplicantsListBox.FormattingEnabled = true;
            viewApplicantsListBox.ItemHeight = 25;
            viewApplicantsListBox.Location = new Point(22, 70);
            viewApplicantsListBox.Name = "viewApplicantsListBox";
            viewApplicantsListBox.Size = new Size(893, 429);
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
            viewApplicantButton.Location = new Point(347, 543);
            viewApplicantButton.Name = "viewApplicantButton";
            viewApplicantButton.Size = new Size(272, 34);
            viewApplicantButton.TabIndex = 2;
            viewApplicantButton.Text = "view application";
            viewApplicantButton.UseVisualStyleBackColor = true;
            viewApplicantButton.Click += viewApplicantButton_Click;
            // 
            // FacultyDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1028, 624);
            Controls.Add(viewApplicantButton);
            Controls.Add(label1);
            Controls.Add(viewApplicantsListBox);
            Margin = new Padding(2, 2, 2, 2);
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
    }
}