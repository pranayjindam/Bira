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
            panelTaskProgress = new Panel();
            labelTaskProgress = new Label();
            panelAssignTasks = new Panel();
            labelAssignTasks = new Label();
            panelRecentTasks = new Panel();
            labelRecentTasks = new Label();
            panelWelcome.SuspendLayout();
            panelTaskProgress.SuspendLayout();
            panelAssignTasks.SuspendLayout();
            panelRecentTasks.SuspendLayout();
            SuspendLayout();
            // 
            // panelWelcome
            // 
            panelWelcome.BackColor = Color.LightSkyBlue;
            panelWelcome.Controls.Add(labelWelcome);
            panelWelcome.Location = new Point(12, 21);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(1004, 108);
            panelWelcome.TabIndex = 0;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 20F);
            labelWelcome.Location = new Point(14, 28);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(185, 54);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome";
            // 
            // panelTaskProgress
            // 
            panelTaskProgress.BackColor = Color.Ivory;
            panelTaskProgress.Controls.Add(labelTaskProgress);
            panelTaskProgress.Location = new Point(732, 279);
            panelTaskProgress.Name = "panelTaskProgress";
            panelTaskProgress.Size = new Size(283, 269);
            panelTaskProgress.TabIndex = 1;
            // 
            // labelTaskProgress
            // 
            labelTaskProgress.AutoSize = true;
            labelTaskProgress.Font = new Font("Segoe UI", 14F);
            labelTaskProgress.Location = new Point(36, 15);
            labelTaskProgress.Name = "labelTaskProgress";
            labelTaskProgress.Size = new Size(184, 38);
            labelTaskProgress.TabIndex = 0;
            labelTaskProgress.Text = "Task Progress";
            // 
            // panelAssignTasks
            // 
            panelAssignTasks.BackColor = Color.Ivory;
            panelAssignTasks.Controls.Add(labelAssignTasks);
            panelAssignTasks.Location = new Point(379, 279);
            panelAssignTasks.Name = "panelAssignTasks";
            panelAssignTasks.Size = new Size(283, 269);
            panelAssignTasks.TabIndex = 2;
            // 
            // labelAssignTasks
            // 
            labelAssignTasks.AutoSize = true;
            labelAssignTasks.Font = new Font("Segoe UI", 14F);
            labelAssignTasks.Location = new Point(58, 16);
            labelAssignTasks.Name = "labelAssignTasks";
            labelAssignTasks.Size = new Size(170, 38);
            labelAssignTasks.TabIndex = 1;
            labelAssignTasks.Text = "Assign Tasks";
            // 
            // panelRecentTasks
            // 
            panelRecentTasks.BackColor = Color.Ivory;
            panelRecentTasks.Controls.Add(labelRecentTasks);
            panelRecentTasks.Location = new Point(26, 279);
            panelRecentTasks.Name = "panelRecentTasks";
            panelRecentTasks.Size = new Size(283, 269);
            panelRecentTasks.TabIndex = 3;
            // 
            // labelRecentTasks
            // 
            labelRecentTasks.AutoSize = true;
            labelRecentTasks.Font = new Font("Segoe UI", 14F);
            labelRecentTasks.Location = new Point(58, 16);
            labelRecentTasks.Name = "labelRecentTasks";
            labelRecentTasks.Size = new Size(173, 38);
            labelRecentTasks.TabIndex = 1;
            labelRecentTasks.Text = "Recent Tasks";
            // 
            // ForYouDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1028, 693);
            Controls.Add(panelRecentTasks);
            Controls.Add(panelAssignTasks);
            Controls.Add(panelTaskProgress);
            Controls.Add(panelWelcome);
            Name = "ForYouDashboard";
            Text = "ForYouDashboard";
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            panelTaskProgress.ResumeLayout(false);
            panelTaskProgress.PerformLayout();
            panelAssignTasks.ResumeLayout(false);
            panelAssignTasks.PerformLayout();
            panelRecentTasks.ResumeLayout(false);
            panelRecentTasks.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelWelcome;
        private Label labelWelcome;
        private Panel panelTaskProgress;
        private Label labelTaskProgress;
        private Panel panelAssignTasks;
        private Label labelAssignTasks;
        private Panel panelRecentTasks;
        private Label labelRecentTasks;
    }
}