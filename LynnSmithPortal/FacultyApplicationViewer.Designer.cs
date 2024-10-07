namespace LynnSmithPortal
{
    partial class FacultyApplicationViewer
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
            downloadEssayLinkLabel = new LinkLabel();
            applicantNameLabel = new Label();
            desiredMajorLabel = new Label();
            referencesLabel = new Label();
            approveButton = new Button();
            RejectButton = new Button();
            commentslabel = new Label();
            emailLabel = new Label();
            saveFileDialog = new SaveFileDialog();
            SuspendLayout();
            // 
            // downloadEssayLinkLabel
            // 
            downloadEssayLinkLabel.AutoSize = true;
            downloadEssayLinkLabel.Location = new Point(394, 492);
            downloadEssayLinkLabel.Name = "downloadEssayLinkLabel";
            downloadEssayLinkLabel.Size = new Size(142, 25);
            downloadEssayLinkLabel.TabIndex = 0;
            downloadEssayLinkLabel.TabStop = true;
            downloadEssayLinkLabel.Text = "Download Essay";
            downloadEssayLinkLabel.LinkClicked += downloadEssayLinkLabel_LinkClicked;
            // 
            // applicantNameLabel
            // 
            applicantNameLabel.AutoSize = true;
            applicantNameLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applicantNameLabel.Location = new Point(351, 82);
            applicantNameLabel.Name = "applicantNameLabel";
            applicantNameLabel.Size = new Size(244, 45);
            applicantNameLabel.TabIndex = 1;
            applicantNameLabel.Text = "applicant name";
            applicantNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            applicantNameLabel.Click += applicantNameLabel_Click;
            // 
            // desiredMajorLabel
            // 
            desiredMajorLabel.AutoSize = true;
            desiredMajorLabel.Location = new Point(403, 236);
            desiredMajorLabel.Name = "desiredMajorLabel";
            desiredMajorLabel.Size = new Size(121, 25);
            desiredMajorLabel.TabIndex = 2;
            desiredMajorLabel.Text = "desired major";
            desiredMajorLabel.TextAlign = ContentAlignment.TopCenter;
            desiredMajorLabel.Click += desiredMajorLabel_Click;
            // 
            // referencesLabel
            // 
            referencesLabel.AutoSize = true;
            referencesLabel.Location = new Point(417, 310);
            referencesLabel.Name = "referencesLabel";
            referencesLabel.Size = new Size(92, 25);
            referencesLabel.TabIndex = 3;
            referencesLabel.Text = "references";
            referencesLabel.TextAlign = ContentAlignment.TopCenter;
            referencesLabel.Click += referencesLabel_Click;
            // 
            // approveButton
            // 
            approveButton.Location = new Point(237, 599);
            approveButton.Name = "approveButton";
            approveButton.Size = new Size(112, 34);
            approveButton.TabIndex = 4;
            approveButton.Text = "Approve";
            approveButton.UseVisualStyleBackColor = true;
            approveButton.Click += approveButton_Click;
            // 
            // RejectButton
            // 
            RejectButton.Location = new Point(576, 599);
            RejectButton.Name = "RejectButton";
            RejectButton.Size = new Size(112, 34);
            RejectButton.TabIndex = 5;
            RejectButton.Text = "Reject";
            RejectButton.UseVisualStyleBackColor = true;
            RejectButton.Click += RejectButton_Click;
            // 
            // commentslabel
            // 
            commentslabel.AutoSize = true;
            commentslabel.Location = new Point(365, 400);
            commentslabel.Name = "commentslabel";
            commentslabel.Size = new Size(180, 25);
            commentslabel.TabIndex = 6;
            commentslabel.Text = "additional comments";
            commentslabel.TextAlign = ContentAlignment.TopCenter;
            commentslabel.Click += commentslabel_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(441, 168);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(54, 25);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "email";
            emailLabel.TextAlign = ContentAlignment.TopCenter;
            emailLabel.Click += emailLabel_Click;
            // 
            // FacultyApplicationViewer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(972, 660);
            Controls.Add(emailLabel);
            Controls.Add(commentslabel);
            Controls.Add(RejectButton);
            Controls.Add(approveButton);
            Controls.Add(referencesLabel);
            Controls.Add(desiredMajorLabel);
            Controls.Add(applicantNameLabel);
            Controls.Add(downloadEssayLinkLabel);
            Name = "FacultyApplicationViewer";
            Text = "Application Viewer";
            Load += FacultyApplicationViewer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel downloadEssayLinkLabel;
        private Label applicantNameLabel;
        private Label desiredMajorLabel;
        private Label referencesLabel;
        private Button approveButton;
        private Button RejectButton;
        private Label commentslabel;
        private Label emailLabel;
        private SaveFileDialog saveFileDialog;
    }
}