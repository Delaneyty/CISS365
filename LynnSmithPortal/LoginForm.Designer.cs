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
            createAccountlinkLabel = new LinkLabel();
            label1 = new Label();
            loginButton = new Button();
            passwordTextField = new TextBox();
            emailTextBox = new TextBox();
            loginGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // PageTitle
            // 
            PageTitle.AutoSize = true;
            PageTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PageTitle.Location = new Point(321, 38);
            PageTitle.Margin = new Padding(5, 0, 5, 0);
            PageTitle.Name = "PageTitle";
            PageTitle.Size = new Size(713, 106);
            PageTitle.TabIndex = 0;
            PageTitle.Text = "Lynn Smith Portal";
            PageTitle.TextAlign = ContentAlignment.MiddleCenter;
            PageTitle.Click += label1_Click;
            // 
            // loginGroupBox
            // 
            loginGroupBox.Controls.Add(createAccountlinkLabel);
            loginGroupBox.Controls.Add(label1);
            loginGroupBox.Controls.Add(loginButton);
            loginGroupBox.Controls.Add(passwordTextField);
            loginGroupBox.Controls.Add(emailTextBox);
            loginGroupBox.Location = new Point(350, 180);
            loginGroupBox.Margin = new Padding(5);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Padding = new Padding(5);
            loginGroupBox.Size = new Size(702, 650);
            loginGroupBox.TabIndex = 1;
            loginGroupBox.TabStop = false;
            loginGroupBox.Text = "login";
            loginGroupBox.Enter += loginGroupBox_Enter;
            // 
            // createAccountlinkLabel
            // 
            createAccountlinkLabel.AutoSize = true;
            createAccountlinkLabel.Location = new Point(223, 500);
            createAccountlinkLabel.Name = "createAccountlinkLabel";
            createAccountlinkLabel.Size = new Size(221, 41);
            createAccountlinkLabel.TabIndex = 4;
            createAccountlinkLabel.TabStop = true;
            createAccountlinkLabel.Text = "Create Account";
            createAccountlinkLabel.LinkClicked += createAccountlinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(308, 431);
            label1.Name = "label1";
            label1.Size = new Size(46, 41);
            label1.TabIndex = 3;
            label1.Text = "or";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(238, 340);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(188, 58);
            loginButton.TabIndex = 2;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextField
            // 
            passwordTextField.Location = new Point(59, 241);
            passwordTextField.Name = "passwordTextField";
            passwordTextField.PlaceholderText = "Password";
            passwordTextField.Size = new Size(543, 47);
            passwordTextField.TabIndex = 1;
            passwordTextField.UseSystemPasswordChar = true;
            passwordTextField.TextChanged += passwordTextField_TextChanged;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(59, 109);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email";
            emailTextBox.Size = new Size(543, 47);
            emailTextBox.TabIndex = 0;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 1301);
            Controls.Add(loginGroupBox);
            Controls.Add(PageTitle);
            Margin = new Padding(5);
            Name = "LoginForm";
            Text = "Login";
            loginGroupBox.ResumeLayout(false);
            loginGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PageTitle;
        private GroupBox loginGroupBox;
        private TextBox emailTextBox;
        private TextBox passwordTextField;
        private Button loginButton;
        private LinkLabel createAccountlinkLabel;
        private Label label1;
    }
}
