namespace LynnSmithPortal
{
    partial class HomePage
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
            linkLabel1 = new LinkLabel();
            facultyLinkLabel = new LinkLabel();
            adminLinkLabel = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(172, 349);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(205, 41);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Student Portal";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // facultyLinkLabel
            // 
            facultyLinkLabel.AutoSize = true;
            facultyLinkLabel.Location = new Point(610, 349);
            facultyLinkLabel.Name = "facultyLinkLabel";
            facultyLinkLabel.Size = new Size(194, 41);
            facultyLinkLabel.TabIndex = 1;
            facultyLinkLabel.TabStop = true;
            facultyLinkLabel.Text = "Faculty Portal";
            facultyLinkLabel.LinkClicked += facultyLinkLabel_LinkClicked;
            // 
            // adminLinkLabel
            // 
            adminLinkLabel.AutoSize = true;
            adminLinkLabel.Location = new Point(1045, 349);
            adminLinkLabel.Name = "adminLinkLabel";
            adminLinkLabel.Size = new Size(189, 41);
            adminLinkLabel.TabIndex = 2;
            adminLinkLabel.TabStop = true;
            adminLinkLabel.Text = "Admin Portal";
            adminLinkLabel.LinkClicked += adminLinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 90);
            label1.Name = "label1";
            label1.Size = new Size(911, 106);
            label1.TabIndex = 3;
            label1.Text = "Lynn Smith University";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 853);
            Controls.Add(label1);
            Controls.Add(adminLinkLabel);
            Controls.Add(facultyLinkLabel);
            Controls.Add(linkLabel1);
            Name = "HomePage";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel facultyLinkLabel;
        private LinkLabel adminLinkLabel;
        private Label label1;
    }
}