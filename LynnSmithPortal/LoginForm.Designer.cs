namespace LynnSmithPortal
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PageTitle = new Label();
            loginGroupBox = new GroupBox();
            SuspendLayout();
            // 
            // PageTitle
            // 
            PageTitle.AutoSize = true;
            PageTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PageTitle.Location = new Point(189, 23);
            PageTitle.Name = "PageTitle";
            PageTitle.Size = new Size(430, 65);
            PageTitle.TabIndex = 0;
            PageTitle.Text = "Lynn Smith Portal";
            PageTitle.TextAlign = ContentAlignment.MiddleCenter;
            PageTitle.Click += label1_Click;
            // 
            // loginGroupBox
            // 
            loginGroupBox.Location = new Point(206, 110);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Size = new Size(413, 446);
            loginGroupBox.TabIndex = 1;
            loginGroupBox.TabStop = false;
            loginGroupBox.Text = "login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 793);
            Controls.Add(loginGroupBox);
            Controls.Add(PageTitle);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PageTitle;
        private GroupBox loginGroupBox;
    }
}
