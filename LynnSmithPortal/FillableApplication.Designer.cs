namespace LynnSmithPortal
{
    partial class FillableApplication
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
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            uploadEssay = new Button();
            fileName = new Label();
            button1 = new Button();
            desiredMajorTextBox = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 481);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Additional Comments";
            textBox1.Size = new Size(713, 219);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // uploadEssay
            // 
            uploadEssay.Location = new Point(130, 69);
            uploadEssay.Name = "uploadEssay";
            uploadEssay.Size = new Size(299, 58);
            uploadEssay.TabIndex = 1;
            uploadEssay.Text = "Upload Essay";
            uploadEssay.UseVisualStyleBackColor = true;
            uploadEssay.Click += uploadEssay_Click;
            // 
            // fileName
            // 
            fileName.AutoSize = true;
            fileName.Location = new Point(488, 78);
            fileName.Name = "fileName";
            fileName.Size = new Size(139, 41);
            fileName.TabIndex = 2;
            fileName.Text = "file name";
            fileName.Click += fileName_Click;
            // 
            // button1
            // 
            button1.Location = new Point(293, 774);
            button1.Name = "button1";
            button1.Size = new Size(396, 58);
            button1.TabIndex = 3;
            button1.Text = "Submit Application";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // desiredMajorTextBox
            // 
            desiredMajorTextBox.Location = new Point(130, 166);
            desiredMajorTextBox.Name = "desiredMajorTextBox";
            desiredMajorTextBox.PlaceholderText = "Desired Major";
            desiredMajorTextBox.Size = new Size(713, 47);
            desiredMajorTextBox.TabIndex = 4;
            desiredMajorTextBox.TextChanged += desiredMajor_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 255);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "References";
            textBox2.Size = new Size(713, 193);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // FillableApplication
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(978, 925);
            Controls.Add(textBox2);
            Controls.Add(desiredMajorTextBox);
            Controls.Add(button1);
            Controls.Add(fileName);
            Controls.Add(uploadEssay);
            Controls.Add(textBox1);
            Name = "FillableApplication";
            Text = "New Application";
            Load += FillableApplication_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private Button uploadEssay;
        private Label fileName;
        private Button button1;
        private TextBox desiredMajorTextBox;
        private TextBox textBox2;
    }
}