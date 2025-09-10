namespace Bira
{
    partial class MemberDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDashboard));
            panelSidebar = new Panel();
            buttonLogout = new Button();
            panelWrapTasks = new Panel();
            panelTasksMenu = new Panel();
            buttonTasksShowMore = new Button();
            buttonTasks = new Button();
            panelWrapTeams = new Panel();
            panelTeamsMenu = new Panel();
            buttonTeamsShowMore = new Button();
            buttonTeams = new Button();
            panelWrapProjects = new Panel();
            panelProjectsMenu = new Panel();
            buttonProjectsShowMore = new Button();
            buttonProjects = new Button();
            panelMain = new Panel();
            panelSidebar.SuspendLayout();
            panelWrapTasks.SuspendLayout();
            panelTasksMenu.SuspendLayout();
            panelWrapTeams.SuspendLayout();
            panelTeamsMenu.SuspendLayout();
            panelWrapProjects.SuspendLayout();
            panelProjectsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.AutoScroll = true;
            panelSidebar.BackColor = Color.FromArgb(11, 7, 17);
            panelSidebar.Controls.Add(buttonLogout);
            panelSidebar.Controls.Add(panelWrapTasks);
            panelSidebar.Controls.Add(panelWrapTeams);
            panelSidebar.Controls.Add(panelWrapProjects);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 749);
            panelSidebar.TabIndex = 1;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Red;
            buttonLogout.Dock = DockStyle.Bottom;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            buttonLogout.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.ForeColor = SystemColors.ButtonHighlight;
            buttonLogout.Location = new Point(0, 720);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(250, 29);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // panelWrapTasks
            // 
            panelWrapTasks.AutoSize = true;
            panelWrapTasks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelWrapTasks.Controls.Add(panelTasksMenu);
            panelWrapTasks.Controls.Add(buttonTasks);
            panelWrapTasks.Dock = DockStyle.Top;
            panelWrapTasks.Location = new Point(0, 160);
            panelWrapTasks.Name = "panelWrapTasks";
            panelWrapTasks.Size = new Size(250, 80);
            panelWrapTasks.TabIndex = 0;
            // 
            // panelTasksMenu
            // 
            panelTasksMenu.AutoSize = true;
            panelTasksMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTasksMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelTasksMenu.Controls.Add(buttonTasksShowMore);
            panelTasksMenu.Dock = DockStyle.Top;
            panelTasksMenu.Location = new Point(0, 40);
            panelTasksMenu.Name = "panelTasksMenu";
            panelTasksMenu.Size = new Size(250, 40);
            panelTasksMenu.TabIndex = 0;
            // 
            // buttonTasksShowMore
            // 
            buttonTasksShowMore.Dock = DockStyle.Top;
            buttonTasksShowMore.FlatAppearance.BorderSize = 0;
            buttonTasksShowMore.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 151, 234);
            buttonTasksShowMore.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 151, 234);
            buttonTasksShowMore.FlatStyle = FlatStyle.Flat;
            buttonTasksShowMore.ForeColor = Color.LightGray;
            buttonTasksShowMore.Location = new Point(0, 0);
            buttonTasksShowMore.Name = "buttonTasksShowMore";
            buttonTasksShowMore.Padding = new Padding(35, 0, 0, 0);
            buttonTasksShowMore.Size = new Size(250, 40);
            buttonTasksShowMore.TabIndex = 0;
            buttonTasksShowMore.Text = "Show More";
            buttonTasksShowMore.TextAlign = ContentAlignment.MiddleLeft;
            buttonTasksShowMore.Click += buttonTasksShowMore_Click;
            // 
            // buttonTasks
            // 
            buttonTasks.Dock = DockStyle.Top;
            buttonTasks.FlatAppearance.BorderSize = 0;
            buttonTasks.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            buttonTasks.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            buttonTasks.FlatStyle = FlatStyle.Flat;
            buttonTasks.ForeColor = Color.Gainsboro;
            buttonTasks.Location = new Point(0, 0);
            buttonTasks.Name = "buttonTasks";
            buttonTasks.Padding = new Padding(10, 0, 0, 0);
            buttonTasks.Size = new Size(250, 40);
            buttonTasks.TabIndex = 1;
            buttonTasks.Text = "Tasks";
            buttonTasks.TextAlign = ContentAlignment.MiddleLeft;
            buttonTasks.Click += buttonTasks_Click;
            // 
            // panelWrapTeams
            // 
            panelWrapTeams.AutoSize = true;
            panelWrapTeams.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelWrapTeams.Controls.Add(panelTeamsMenu);
            panelWrapTeams.Controls.Add(buttonTeams);
            panelWrapTeams.Dock = DockStyle.Top;
            panelWrapTeams.Location = new Point(0, 80);
            panelWrapTeams.Name = "panelWrapTeams";
            panelWrapTeams.Size = new Size(250, 80);
            panelWrapTeams.TabIndex = 1;
            // 
            // panelTeamsMenu
            // 
            panelTeamsMenu.AutoSize = true;
            panelTeamsMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTeamsMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelTeamsMenu.Controls.Add(buttonTeamsShowMore);
            panelTeamsMenu.Dock = DockStyle.Top;
            panelTeamsMenu.Location = new Point(0, 40);
            panelTeamsMenu.Name = "panelTeamsMenu";
            panelTeamsMenu.Size = new Size(250, 40);
            panelTeamsMenu.TabIndex = 0;
            // 
            // buttonTeamsShowMore
            // 
            buttonTeamsShowMore.Dock = DockStyle.Top;
            buttonTeamsShowMore.FlatAppearance.BorderSize = 0;
            buttonTeamsShowMore.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 151, 234);
            buttonTeamsShowMore.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 151, 234);
            buttonTeamsShowMore.FlatStyle = FlatStyle.Flat;
            buttonTeamsShowMore.ForeColor = Color.LightGray;
            buttonTeamsShowMore.Location = new Point(0, 0);
            buttonTeamsShowMore.Name = "buttonTeamsShowMore";
            buttonTeamsShowMore.Padding = new Padding(35, 0, 0, 0);
            buttonTeamsShowMore.Size = new Size(250, 40);
            buttonTeamsShowMore.TabIndex = 0;
            buttonTeamsShowMore.Text = "Show More";
            buttonTeamsShowMore.TextAlign = ContentAlignment.MiddleLeft;
            buttonTeamsShowMore.Click += buttonTeamsShowMore_Click;
            // 
            // buttonTeams
            // 
            buttonTeams.Dock = DockStyle.Top;
            buttonTeams.FlatAppearance.BorderSize = 0;
            buttonTeams.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            buttonTeams.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            buttonTeams.FlatStyle = FlatStyle.Flat;
            buttonTeams.ForeColor = Color.Gainsboro;
            buttonTeams.Location = new Point(0, 0);
            buttonTeams.Name = "buttonTeams";
            buttonTeams.Padding = new Padding(10, 0, 0, 0);
            buttonTeams.Size = new Size(250, 40);
            buttonTeams.TabIndex = 1;
            buttonTeams.Text = "Teams";
            buttonTeams.TextAlign = ContentAlignment.MiddleLeft;
            buttonTeams.Click += buttonTeams_Click;
            // 
            // panelWrapProjects
            // 
            panelWrapProjects.AutoSize = true;
            panelWrapProjects.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelWrapProjects.Controls.Add(panelProjectsMenu);
            panelWrapProjects.Controls.Add(buttonProjects);
            panelWrapProjects.Dock = DockStyle.Top;
            panelWrapProjects.Location = new Point(0, 0);
            panelWrapProjects.Name = "panelWrapProjects";
            panelWrapProjects.Size = new Size(250, 80);
            panelWrapProjects.TabIndex = 2;
            // 
            // panelProjectsMenu
            // 
            panelProjectsMenu.AutoSize = true;
            panelProjectsMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelProjectsMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelProjectsMenu.Controls.Add(buttonProjectsShowMore);
            panelProjectsMenu.Dock = DockStyle.Top;
            panelProjectsMenu.Location = new Point(0, 40);
            panelProjectsMenu.Name = "panelProjectsMenu";
            panelProjectsMenu.Size = new Size(250, 40);
            panelProjectsMenu.TabIndex = 0;
            // 
            // buttonProjectsShowMore
            // 
            buttonProjectsShowMore.Dock = DockStyle.Top;
            buttonProjectsShowMore.FlatAppearance.BorderSize = 0;
            buttonProjectsShowMore.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 151, 234);
            buttonProjectsShowMore.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 151, 234);
            buttonProjectsShowMore.FlatStyle = FlatStyle.Flat;
            buttonProjectsShowMore.ForeColor = Color.LightGray;
            buttonProjectsShowMore.Location = new Point(0, 0);
            buttonProjectsShowMore.Name = "buttonProjectsShowMore";
            buttonProjectsShowMore.Padding = new Padding(35, 0, 0, 0);
            buttonProjectsShowMore.Size = new Size(250, 40);
            buttonProjectsShowMore.TabIndex = 0;
            buttonProjectsShowMore.Text = "Show More";
            buttonProjectsShowMore.TextAlign = ContentAlignment.MiddleLeft;
            buttonProjectsShowMore.Click += buttonProjectsShowMore_Click;
            // 
            // buttonProjects
            // 
            buttonProjects.Dock = DockStyle.Top;
            buttonProjects.FlatAppearance.BorderSize = 0;
            buttonProjects.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            buttonProjects.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            buttonProjects.FlatStyle = FlatStyle.Flat;
            buttonProjects.ForeColor = Color.Gainsboro;
            buttonProjects.Location = new Point(0, 0);
            buttonProjects.Name = "buttonProjects";
            buttonProjects.Padding = new Padding(10, 0, 0, 0);
            buttonProjects.Size = new Size(250, 40);
            buttonProjects.TabIndex = 1;
            buttonProjects.Text = "Projects";
            buttonProjects.TextAlign = ContentAlignment.MiddleLeft;
            buttonProjects.Click += buttonProjects_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1050, 749);
            panelMain.TabIndex = 0;
            // 
            // MemberDashboard
            // 
            ClientSize = new Size(1300, 749);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MemberDashboard";
            Text = "Member Dashboard";
            WindowState = FormWindowState.Maximized;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelWrapTasks.ResumeLayout(false);
            panelWrapTasks.PerformLayout();
            panelTasksMenu.ResumeLayout(false);
            panelWrapTeams.ResumeLayout(false);
            panelWrapTeams.PerformLayout();
            panelTeamsMenu.ResumeLayout(false);
            panelWrapProjects.ResumeLayout(false);
            panelWrapProjects.PerformLayout();
            panelProjectsMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelWrapProjects;
        private Button buttonProjects;
        private Panel panelProjectsMenu;
        private Button buttonProjectsShowMore;

        private Panel panelWrapTeams;
        private Button buttonTeams;
        private Panel panelTeamsMenu;
        private Button buttonTeamsShowMore;

        private Panel panelWrapTasks;
        private Button buttonTasks;
        private Panel panelTasksMenu;
        private Button buttonTasksShowMore;

        private Panel panelMain;
        private Button buttonLogout;
    }
}