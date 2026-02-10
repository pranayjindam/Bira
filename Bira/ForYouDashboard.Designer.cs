using System.Windows.Forms;
using System.Drawing;

namespace Bira
{
    partial class ForYouDashboard
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
            labelWelcome = new Label();
            panelUserInfo = new Panel();
            labelRole = new Label();
            labelEmail = new Label();
            labelFullName = new Label();
            labelUserProfileTitle = new Label();
            panelTaskProgressContainer = new Panel();
            panelTaskProgress = new FlowLayoutPanel();
            labelTaskProgressTitle = new Label();
            panelUserInfo.SuspendLayout();
            panelTaskProgressContainer.SuspendLayout();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelWelcome.ForeColor = Color.FromArgb(37, 99, 235);
            labelWelcome.Location = new Point(42, 38);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(217, 60);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome";
            // 
            // panelUserInfo
            // 
            panelUserInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelUserInfo.BackColor = Color.FromArgb(248, 250, 252);
            panelUserInfo.Controls.Add(labelRole);
            panelUserInfo.Controls.Add(labelEmail);
            panelUserInfo.Controls.Add(labelFullName);
            panelUserInfo.Controls.Add(labelUserProfileTitle);
            panelUserInfo.Location = new Point(54, 138);
            panelUserInfo.Margin = new Padding(3, 4, 3, 4);
            panelUserInfo.Name = "panelUserInfo";
            panelUserInfo.Size = new Size(1096, 250);
            panelUserInfo.TabIndex = 1;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRole.ForeColor = Color.FromArgb(71, 85, 105);
            labelRole.Location = new Point(33, 181);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(60, 32);
            labelRole.TabIndex = 3;
            labelRole.Text = "Role";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.FromArgb(71, 85, 105);
            labelEmail.Location = new Point(33, 138);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(71, 32);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelFullName.ForeColor = Color.FromArgb(37, 99, 235);
            labelFullName.Location = new Point(31, 81);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(161, 38);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "User Name";
            // 
            // labelUserProfileTitle
            // 
            labelUserProfileTitle.AutoSize = true;
            labelUserProfileTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelUserProfileTitle.ForeColor = Color.FromArgb(30, 41, 59);
            labelUserProfileTitle.Location = new Point(28, 19);
            labelUserProfileTitle.Name = "labelUserProfileTitle";
            labelUserProfileTitle.Size = new Size(196, 45);
            labelUserProfileTitle.TabIndex = 0;
            labelUserProfileTitle.Text = "User Profile";
            // 
            // panelTaskProgressContainer
            // 
            panelTaskProgressContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTaskProgressContainer.BackColor = Color.FromArgb(248, 250, 252);
            panelTaskProgressContainer.Controls.Add(panelTaskProgress);
            panelTaskProgressContainer.Controls.Add(labelTaskProgressTitle);
            panelTaskProgressContainer.Location = new Point(54, 425);
            panelTaskProgressContainer.Margin = new Padding(3, 4, 3, 4);
            panelTaskProgressContainer.Name = "panelTaskProgressContainer";
            panelTaskProgressContainer.Padding = new Padding(22, 25, 22, 25);
            panelTaskProgressContainer.Size = new Size(1096, 608);
            panelTaskProgressContainer.TabIndex = 2;
            // 
            // panelTaskProgress
            // 
            panelTaskProgress.AutoScroll = true;
            panelTaskProgress.BackColor = Color.Transparent;
            panelTaskProgress.Dock = DockStyle.Fill;
            panelTaskProgress.FlowDirection = FlowDirection.TopDown;
            panelTaskProgress.Location = new Point(22, 70);
            panelTaskProgress.Margin = new Padding(3, 4, 3, 4);
            panelTaskProgress.Name = "panelTaskProgress";
            panelTaskProgress.Size = new Size(1052, 513);
            panelTaskProgress.TabIndex = 0;
            panelTaskProgress.WrapContents = false;
            // 
            // labelTaskProgressTitle
            // 
            labelTaskProgressTitle.AutoSize = true;
            labelTaskProgressTitle.Dock = DockStyle.Top;
            labelTaskProgressTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTaskProgressTitle.ForeColor = Color.FromArgb(30, 41, 59);
            labelTaskProgressTitle.Location = new Point(22, 25);
            labelTaskProgressTitle.Name = "labelTaskProgressTitle";
            labelTaskProgressTitle.Size = new Size(225, 45);
            labelTaskProgressTitle.TabIndex = 0;
            labelTaskProgressTitle.Text = "Task Progress";
            // 
            // ForYouDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1196, 906);
            Controls.Add(panelTaskProgressContainer);
            Controls.Add(panelUserInfo);
            Controls.Add(labelWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ForYouDashboard";
            Text = "ForYouDashboard";
            panelUserInfo.ResumeLayout(false);
            panelUserInfo.PerformLayout();
            panelTaskProgressContainer.ResumeLayout(false);
            panelTaskProgressContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        // 
        // private fields
        // 
        private Label labelWelcome;
        private Panel panelUserInfo;
        private Label labelUserProfileTitle;
        private Label labelFullName;
        private Label labelEmail;
        private Label labelRole;
        private Panel panelTaskProgressContainer;
        private Label labelTaskProgressTitle;
        private FlowLayoutPanel panelTaskProgress;
    }

    #endregion
}