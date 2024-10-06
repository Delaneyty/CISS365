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
            SuspendLayout();
            // 
            // fallRadioButton
            // 
            fallRadioButton.AutoSize = true;
            fallRadioButton.Location = new Point(62, 153);
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
            springRadioButton.Location = new Point(62, 236);
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
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(272, 72);
            label1.TabIndex = 2;
            label1.Text = "Semester:";
            // 
            // registerCourseButton
            // 
            registerCourseButton.Location = new Point(739, 673);
            registerCourseButton.Name = "registerCourseButton";
            registerCourseButton.Size = new Size(188, 126);
            registerCourseButton.TabIndex = 3;
            registerCourseButton.Text = "Register Course";
            registerCourseButton.UseVisualStyleBackColor = true;
            registerCourseButton.Click += registerCourseButton_Click;
            // 
            // courseListBox
            // 
            courseListBox.FormattingEnabled = true;
            courseListBox.Location = new Point(490, 85);
            courseListBox.Name = "courseListBox";
            courseListBox.Size = new Size(1137, 532);
            courseListBox.TabIndex = 4;
            // 
            // RegisterCourseForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1822, 927);
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
    }
}