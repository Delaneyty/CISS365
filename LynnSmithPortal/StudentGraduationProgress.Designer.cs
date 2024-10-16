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
            coursesTakenListBox.ItemHeight = 25;
            coursesTakenListBox.Location = new Point(17, 47);
            coursesTakenListBox.Margin = new Padding(4, 5, 4, 5);
            coursesTakenListBox.Name = "coursesTakenListBox";
            coursesTakenListBox.Size = new Size(817, 329);
            coursesTakenListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 1;
            label1.Text = "Courses Taken:";
            // 
            // label2
            // 
            label2.Location = new Point(858, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(166, 63);
            label2.TabIndex = 2;
            label2.Text = "Credits Completed With a C or More:";
            // 
            // label3
            // 
            label3.Location = new Point(858, 155);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 62);
            label3.TabIndex = 3;
            label3.Text = "Credits Required to Gradutae:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(858, 216);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 4;
            label4.Text = "Credits Remaining:";
            // 
            // creditsCompletedLabel
            // 
            creditsCompletedLabel.AutoSize = true;
            creditsCompletedLabel.Location = new Point(1055, 91);
            creditsCompletedLabel.Margin = new Padding(4, 0, 4, 0);
            creditsCompletedLabel.Name = "creditsCompletedLabel";
            creditsCompletedLabel.Size = new Size(182, 25);
            creditsCompletedLabel.TabIndex = 5;
            creditsCompletedLabel.Text = "                                  ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1055, 155);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 6;
            label6.Text = "120";
            // 
            // creditsRemainingLabel
            // 
            creditsRemainingLabel.AutoSize = true;
            creditsRemainingLabel.Location = new Point(1055, 216);
            creditsRemainingLabel.Margin = new Padding(4, 0, 4, 0);
            creditsRemainingLabel.Name = "creditsRemainingLabel";
            creditsRemainingLabel.Size = new Size(92, 25);
            creditsRemainingLabel.TabIndex = 7;
            creditsRemainingLabel.Text = "                ";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(931, 278);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(107, 38);
            exitButton.TabIndex = 8;
            exitButton.Text = "Close Form";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // StudentGraduationProgress
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1251, 556);
            Controls.Add(exitButton);
            Controls.Add(creditsRemainingLabel);
            Controls.Add(label6);
            Controls.Add(creditsCompletedLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(coursesTakenListBox);
            Margin = new Padding(4, 5, 4, 5);
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