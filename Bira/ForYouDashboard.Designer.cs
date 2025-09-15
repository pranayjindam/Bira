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
            panelWelcome = new Panel();
            labelWelcome = new Label();
            labelTaskProgress = new Label();
            panelAssignTasks = new Panel();
            labelAssignTasks = new Label();
            panelTaskProgress = new FlowLayoutPanel();
            labelEmail = new Label();
            labelFirstname = new Label();
            labelLastname = new Label();
            labelRole = new Label();
            panelWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // panelWelcome
            // 
            panelWelcome.BackColor = Color.LightSkyBlue;
            panelWelcome.Controls.Add(labelWelcome);
            panelWelcome.Dock = DockStyle.Top;
            panelWelcome.Location = new Point(0, 0);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(1674, 108);
            panelWelcome.TabIndex = 0;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 24F);
            labelWelcome.Location = new Point(14, 28);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(224, 65);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome";
            // 
            // labelTaskProgress
            // 
            labelTaskProgress.AutoSize = true;
            labelTaskProgress.Font = new Font("Segoe UI", 16F);
            labelTaskProgress.Location = new Point(915, 417);
            labelTaskProgress.Name = "labelTaskProgress";
            labelTaskProgress.Size = new Size(211, 45);
            labelTaskProgress.TabIndex = 0;
            labelTaskProgress.Text = "Task Progress";
            // 
            // panelAssignTasks
            // 
            panelAssignTasks.BackColor = Color.MintCream;
            panelAssignTasks.Location = new Point(63, 513);
            panelAssignTasks.Name = "panelAssignTasks";
            panelAssignTasks.Size = new Size(449, 459);
            panelAssignTasks.TabIndex = 2;
            // 
            // labelAssignTasks
            // 
            labelAssignTasks.AutoSize = true;
            labelAssignTasks.Font = new Font("Segoe UI", 16F);
            labelAssignTasks.Location = new Point(189, 417);
            labelAssignTasks.Name = "labelAssignTasks";
            labelAssignTasks.Size = new Size(196, 45);
            labelAssignTasks.TabIndex = 1;
            labelAssignTasks.Text = "Assign Tasks";
            // 
            // panelTaskProgress
            // 
            panelTaskProgress.BackColor = Color.MintCream;
            panelTaskProgress.Location = new Point(796, 513);
            panelTaskProgress.Name = "panelTaskProgress";
            panelTaskProgress.Size = new Size(449, 459);
            panelTaskProgress.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14F);
            labelEmail.Location = new Point(63, 148);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(105, 38);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email : ";
            // 
            // labelFirstname
            // 
            labelFirstname.AutoSize = true;
            labelFirstname.Font = new Font("Segoe UI", 14F);
            labelFirstname.Location = new Point(63, 228);
            labelFirstname.Name = "labelFirstname";
            labelFirstname.Size = new Size(173, 38);
            labelFirstname.TabIndex = 7;
            labelFirstname.Text = "First Name : ";
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Font = new Font("Segoe UI", 14F);
            labelLastname.Location = new Point(63, 308);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(169, 38);
            labelLastname.TabIndex = 8;
            labelLastname.Text = "Last Name : ";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 14F);
            labelRole.Location = new Point(980, 228);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(85, 38);
            labelRole.TabIndex = 9;
            labelRole.Text = "Role :";
            // 
            // ForYouDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1674, 1050);
            Controls.Add(labelRole);
            Controls.Add(labelLastname);
            Controls.Add(labelFirstname);
            Controls.Add(labelEmail);
            Controls.Add(panelTaskProgress);
            Controls.Add(labelTaskProgress);
            Controls.Add(labelAssignTasks);
            Controls.Add(panelAssignTasks);
            Controls.Add(panelWelcome);
            Name = "ForYouDashboard";
            Text = "ForYouDashboard";
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelWelcome;
        private Label labelWelcome;
        private Label labelTaskProgress;
        private Panel panelAssignTasks;
        private Label labelAssignTasks;
        private FlowLayoutPanel panelTaskProgress;
        private Label labelEmail;
        private Label labelFirstname;
        private Label labelLastname;
        private Label labelRole;
    }
}