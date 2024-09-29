namespace LynnSmithPortal
{
    partial class CreateAccount
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
            label1 = new Label();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            majorOrDepartmentTextBox = new TextBox();
            createAccountButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(458, 46);
            label1.Name = "label1";
            label1.Size = new Size(464, 81);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(458, 181);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Name";
            nameTextBox.Size = new Size(464, 47);
            nameTextBox.TabIndex = 1;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(458, 288);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email";
            emailTextBox.Size = new Size(464, 47);
            emailTextBox.TabIndex = 2;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(458, 394);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(464, 47);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // majorOrDepartmentTextBox
            // 
            majorOrDepartmentTextBox.Location = new Point(458, 490);
            majorOrDepartmentTextBox.Name = "majorOrDepartmentTextBox";
            majorOrDepartmentTextBox.PlaceholderText = "...";
            majorOrDepartmentTextBox.Size = new Size(464, 47);
            majorOrDepartmentTextBox.TabIndex = 4;
            majorOrDepartmentTextBox.TextChanged += majorOrDepartmentTextBox_TextChanged;
            // 
            // createAccountButton
            // 
            createAccountButton.BackColor = SystemColors.ButtonFace;
            createAccountButton.Location = new Point(525, 583);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(296, 58);
            createAccountButton.TabIndex = 5;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = false;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1413, 1059);
            Controls.Add(createAccountButton);
            Controls.Add(majorOrDepartmentTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "CreateAccount";
            Text = "CreateAccount";
            Load += CreateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox majorOrDepartmentTextBox;
        private Button createAccountButton;
    }
}