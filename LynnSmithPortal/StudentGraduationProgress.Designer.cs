namespace LynnSmithPortal
{
    partial class StudentGraduationProgress
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
            coursesTakenListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            creditsCompletedLabel = new Label();
            label6 = new Label();
            creditsRemainingLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // coursesTakenListBox
            // 
            coursesTakenListBox.FormattingEnabled = true;
            coursesTakenListBox.ItemHeight = 15;
            coursesTakenListBox.Location = new Point(12, 28);
            coursesTakenListBox.Name = "coursesTakenListBox";
            coursesTakenListBox.Size = new Size(268, 199);
            coursesTakenListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Courses Taken:";
            // 
            // label2
            // 
            label2.Location = new Point(331, 68);
            label2.Name = "label2";
            label2.Size = new Size(116, 38);
            label2.TabIndex = 2;
            label2.Text = "Credits Completed With a C or More:";
            // 
            // label3
            // 
            label3.Location = new Point(331, 106);
            label3.Name = "label3";
            label3.Size = new Size(97, 37);
            label3.TabIndex = 3;
            label3.Text = "Credits Required to Gradutae:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 143);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 4;
            label4.Text = "Credits Remaining:";
            // 
            // creditsCompletedLabel
            // 
            creditsCompletedLabel.AutoSize = true;
            creditsCompletedLabel.Location = new Point(469, 68);
            creditsCompletedLabel.Name = "creditsCompletedLabel";
            creditsCompletedLabel.Size = new Size(109, 15);
            creditsCompletedLabel.TabIndex = 5;
            creditsCompletedLabel.Text = "                                  ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 106);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 6;
            label6.Text = "120";
            // 
            // creditsRemainingLabel
            // 
            creditsRemainingLabel.AutoSize = true;
            creditsRemainingLabel.Location = new Point(469, 143);
            creditsRemainingLabel.Name = "creditsRemainingLabel";
            creditsRemainingLabel.Size = new Size(55, 15);
            creditsRemainingLabel.TabIndex = 7;
            creditsRemainingLabel.Text = "                ";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(382, 180);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 8;
            exitButton.Text = "Close Form";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // StudentGraduationProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(546, 248);
            Controls.Add(exitButton);
            Controls.Add(creditsRemainingLabel);
            Controls.Add(label6);
            Controls.Add(creditsCompletedLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(coursesTakenListBox);
            Name = "StudentGraduationProgress";
            Text = "Student Graduation Progress";
            Load += StudentGraduationProgress_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox coursesTakenListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label creditsCompletedLabel;
        private Label label6;
        private Label creditsRemainingLabel;
        private Button exitButton;
    }
}