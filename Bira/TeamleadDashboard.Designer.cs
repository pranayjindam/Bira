namespace Bira
{
    partial class TeamleadDashboard
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
            panelSidebar = new Panel();
            panelTasksMenu = new Panel();
            buttonTasksShowMore = new Button();
            panelTasks = new Panel();
            buttonTasksAdd = new Button();
            buttonTasks = new Button();
            panelTeamsMenu = new Panel();
            buttonTeamsShowMore = new Button();
            panelTeams = new Panel();
            buttonTeamsAdd = new Button();
            buttonTeams = new Button();
            panelProjectsMenu = new Panel();
            buttonProjectsShowMore = new Button();
            panelProjects = new Panel();
            buttonProjectsAdd = new Button();
            buttonProjects = new Button();
            panelForyou = new Panel();
            buttonForyou = new Button();
            panelMain = new Panel();
            panelWrapTasks = new Panel();
            panelWrapTeams = new Panel();
            panelWrapProjects = new Panel();
            panelSidebar.SuspendLayout();
            panelTasksMenu.SuspendLayout();
            panelTasks.SuspendLayout();
            panelTeamsMenu.SuspendLayout();
            panelTeams.SuspendLayout();
            panelProjectsMenu.SuspendLayout();
            panelProjects.SuspendLayout();
            panelForyou.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.AutoScroll = true;
            panelSidebar.BackColor = Color.FromArgb(11, 7, 17);
            panelSidebar.Controls.Add(panelTasksMenu);
            panelSidebar.Controls.Add(panelTasks);
            panelSidebar.Controls.Add(panelTeamsMenu);
            panelSidebar.Controls.Add(panelTeams);
            panelSidebar.Controls.Add(panelProjectsMenu);
            panelSidebar.Controls.Add(panelProjects);
            panelSidebar.Controls.Add(panelForyou);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 749);
            panelSidebar.TabIndex = 1;
            // 
            // panelTasksMenu
            // 
            panelTasksMenu.AutoSize = true;
            panelTasksMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTasksMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelTasksMenu.Controls.Add(buttonTasksShowMore);
            panelTasksMenu.Dock = DockStyle.Top;
            panelTasksMenu.Location = new Point(0, 240);
            panelTasksMenu.Name = "panelTasksMenu";
            panelTasksMenu.Size = new Size(250, 40);
            panelTasksMenu.TabIndex = 12;
            // 
            // buttonTasksShowMore
            // 
            buttonTasksShowMore.Dock = DockStyle.Bottom;
            buttonTasksShowMore.FlatAppearance.BorderSize = 0;
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
            // panelTasks
            // 
            panelTasks.Controls.Add(buttonTasksAdd);
            panelTasks.Controls.Add(buttonTasks);
            panelTasks.Dock = DockStyle.Top;
            panelTasks.Location = new Point(0, 200);
            panelTasks.Name = "panelTasks";
            panelTasks.Size = new Size(250, 40);
            panelTasks.TabIndex = 11;
            // 
            // buttonTasksAdd
            // 
            buttonTasksAdd.BackColor = Color.Black;
            buttonTasksAdd.FlatAppearance.BorderSize = 0;
            buttonTasksAdd.FlatStyle = FlatStyle.Flat;
            buttonTasksAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonTasksAdd.ForeColor = Color.White;
            buttonTasksAdd.Location = new Point(210, 6);
            buttonTasksAdd.Name = "buttonTasksAdd";
            buttonTasksAdd.Size = new Size(34, 40);
            buttonTasksAdd.TabIndex = 7;
            buttonTasksAdd.Text = "+";
            buttonTasksAdd.TextAlign = ContentAlignment.TopCenter;
            buttonTasksAdd.UseVisualStyleBackColor = false;
            // 
            // buttonTasks
            // 
            buttonTasks.Dock = DockStyle.Top;
            buttonTasks.FlatAppearance.BorderSize = 0;
            buttonTasks.FlatStyle = FlatStyle.Flat;
            buttonTasks.ForeColor = Color.Gainsboro;
            buttonTasks.Location = new Point(0, 0);
            buttonTasks.Name = "buttonTasks";
            buttonTasks.Padding = new Padding(10, 0, 0, 0);
            buttonTasks.Size = new Size(250, 40);
            buttonTasks.TabIndex = 2;
            buttonTasks.Text = "Tasks";
            buttonTasks.TextAlign = ContentAlignment.MiddleLeft;
            buttonTasks.Click += buttonTasks_Click;
            // 
            // panelTeamsMenu
            // 
            panelTeamsMenu.AutoSize = true;
            panelTeamsMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTeamsMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelTeamsMenu.Controls.Add(buttonTeamsShowMore);
            panelTeamsMenu.Dock = DockStyle.Top;
            panelTeamsMenu.Location = new Point(0, 160);
            panelTeamsMenu.Name = "panelTeamsMenu";
            panelTeamsMenu.Size = new Size(250, 40);
            panelTeamsMenu.TabIndex = 10;
            // 
            // buttonTeamsShowMore
            // 
            buttonTeamsShowMore.Dock = DockStyle.Bottom;
            buttonTeamsShowMore.FlatAppearance.BorderSize = 0;
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
            // panelTeams
            // 
            panelTeams.Controls.Add(buttonTeamsAdd);
            panelTeams.Controls.Add(buttonTeams);
            panelTeams.Dock = DockStyle.Top;
            panelTeams.Location = new Point(0, 120);
            panelTeams.Name = "panelTeams";
            panelTeams.Size = new Size(250, 40);
            panelTeams.TabIndex = 9;
            // 
            // buttonTeamsAdd
            // 
            buttonTeamsAdd.BackColor = Color.Black;
            buttonTeamsAdd.FlatAppearance.BorderSize = 0;
            buttonTeamsAdd.FlatStyle = FlatStyle.Flat;
            buttonTeamsAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonTeamsAdd.ForeColor = Color.White;
            buttonTeamsAdd.Location = new Point(210, 6);
            buttonTeamsAdd.Name = "buttonTeamsAdd";
            buttonTeamsAdd.Size = new Size(34, 40);
            buttonTeamsAdd.TabIndex = 7;
            buttonTeamsAdd.Text = "+";
            buttonTeamsAdd.TextAlign = ContentAlignment.TopCenter;
            buttonTeamsAdd.UseVisualStyleBackColor = false;
            // 
            // buttonTeams
            // 
            buttonTeams.Dock = DockStyle.Top;
            buttonTeams.FlatAppearance.BorderSize = 0;
            buttonTeams.FlatStyle = FlatStyle.Flat;
            buttonTeams.ForeColor = Color.Gainsboro;
            buttonTeams.Location = new Point(0, 0);
            buttonTeams.Name = "buttonTeams";
            buttonTeams.Padding = new Padding(10, 0, 0, 0);
            buttonTeams.Size = new Size(250, 40);
            buttonTeams.TabIndex = 8;
            buttonTeams.Text = "Teams";
            buttonTeams.TextAlign = ContentAlignment.MiddleLeft;
            buttonTeams.Click += buttonTeams_Click;
            // 
            // panelProjectsMenu
            // 
            panelProjectsMenu.AutoSize = true;
            panelProjectsMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelProjectsMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelProjectsMenu.Controls.Add(buttonProjectsShowMore);
            panelProjectsMenu.Dock = DockStyle.Top;
            panelProjectsMenu.Location = new Point(0, 80);
            panelProjectsMenu.Name = "panelProjectsMenu";
            panelProjectsMenu.Size = new Size(250, 40);
            panelProjectsMenu.TabIndex = 8;
            // 
            // buttonProjectsShowMore
            // 
            buttonProjectsShowMore.Dock = DockStyle.Bottom;
            buttonProjectsShowMore.FlatAppearance.BorderSize = 0;
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
            // panelProjects
            // 
            panelProjects.Controls.Add(buttonProjectsAdd);
            panelProjects.Controls.Add(buttonProjects);
            panelProjects.Dock = DockStyle.Top;
            panelProjects.Location = new Point(0, 40);
            panelProjects.Name = "panelProjects";
            panelProjects.Size = new Size(250, 40);
            panelProjects.TabIndex = 7;
            // 
            // buttonProjectsAdd
            // 
            buttonProjectsAdd.BackColor = Color.Black;
            buttonProjectsAdd.FlatAppearance.BorderSize = 0;
            buttonProjectsAdd.FlatStyle = FlatStyle.Flat;
            buttonProjectsAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonProjectsAdd.ForeColor = Color.White;
            buttonProjectsAdd.Location = new Point(210, 0);
            buttonProjectsAdd.Name = "buttonProjectsAdd";
            buttonProjectsAdd.Size = new Size(34, 40);
            buttonProjectsAdd.TabIndex = 6;
            buttonProjectsAdd.Text = "+";
            buttonProjectsAdd.TextAlign = ContentAlignment.TopCenter;
            buttonProjectsAdd.UseVisualStyleBackColor = false;
            buttonProjectsAdd.Click += buttonProjectsAdd_Click;
            // 
            // buttonProjects
            // 
            buttonProjects.Dock = DockStyle.Top;
            buttonProjects.FlatAppearance.BorderSize = 0;
            buttonProjects.FlatStyle = FlatStyle.Flat;
            buttonProjects.ForeColor = Color.Gainsboro;
            buttonProjects.Location = new Point(0, 0);
            buttonProjects.Name = "buttonProjects";
            buttonProjects.Padding = new Padding(10, 0, 0, 0);
            buttonProjects.Size = new Size(250, 40);
            buttonProjects.TabIndex = 7;
            buttonProjects.Text = "Projects";
            buttonProjects.TextAlign = ContentAlignment.MiddleLeft;
            buttonProjects.Click += buttonProjects_Click;
            // 
            // panelForyou
            // 
            panelForyou.Controls.Add(buttonForyou);
            panelForyou.Dock = DockStyle.Top;
            panelForyou.Location = new Point(0, 0);
            panelForyou.Name = "panelForyou";
            panelForyou.Size = new Size(250, 40);
            panelForyou.TabIndex = 6;
            // 
            // buttonForyou
            // 
            buttonForyou.Dock = DockStyle.Top;
            buttonForyou.FlatAppearance.BorderSize = 0;
            buttonForyou.FlatStyle = FlatStyle.Flat;
            buttonForyou.ForeColor = Color.Gainsboro;
            buttonForyou.Location = new Point(0, 0);
            buttonForyou.Name = "buttonForyou";
            buttonForyou.Padding = new Padding(10, 0, 0, 0);
            buttonForyou.Size = new Size(250, 40);
            buttonForyou.TabIndex = 7;
            buttonForyou.Text = "Foryou";
            buttonForyou.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panelWrapTasks);
            panelMain.Controls.Add(panelWrapTeams);
            panelMain.Controls.Add(panelWrapProjects);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1050, 749);
            panelMain.TabIndex = 0;
            // 
            // panelWrapTasks
            // 
            panelWrapTasks.AutoSize = true;
            panelWrapTasks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelWrapTasks.Dock = DockStyle.Top;
            panelWrapTasks.Location = new Point(0, 0);
            panelWrapTasks.Name = "panelWrapTasks";
            panelWrapTasks.Size = new Size(1050, 0);
            panelWrapTasks.TabIndex = 3;
            // 
            // panelWrapTeams
            // 
            panelWrapTeams.AutoSize = true;
            panelWrapTeams.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelWrapTeams.Dock = DockStyle.Top;
            panelWrapTeams.Location = new Point(0, 0);
            panelWrapTeams.Name = "panelWrapTeams";
            panelWrapTeams.Size = new Size(1050, 0);
            panelWrapTeams.TabIndex = 4;
            // 
            // panelWrapProjects
            // 
            panelWrapProjects.AutoSize = true;
            panelWrapProjects.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelWrapProjects.Dock = DockStyle.Top;
            panelWrapProjects.Location = new Point(0, 0);
            panelWrapProjects.Name = "panelWrapProjects";
            panelWrapProjects.Size = new Size(1050, 0);
            panelWrapProjects.TabIndex = 5;
            // 
            // TeamleadDashboard
            // 
            ClientSize = new Size(1300, 749);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "TeamleadDashboard";
            Text = "Member Dashboard";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelTasksMenu.ResumeLayout(false);
            panelTasks.ResumeLayout(false);
            panelTeamsMenu.ResumeLayout(false);
            panelTeams.ResumeLayout(false);
            panelProjectsMenu.ResumeLayout(false);
            panelProjects.ResumeLayout(false);
            panelForyou.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Panel panelSidebar;

        private Panel panelMain;
        private Panel panelForyou;
        private Panel panelWrapTasks;
        private Panel panelWrapTeams;
        private Panel panelWrapProjects;
        private Panel panelTeams;
        private Button buttonTeams;
        private Panel panelProjectsMenu;
        private Button buttonProjectsShowMore;
        private Panel panelProjects;
        private Button buttonProjects;
        private Button buttonForyou;
        private Panel panelTasksMenu;
        private Button buttonTasksShowMore;
        private Panel panelTasks;
        private Button buttonTasksAdd;
        private Button buttonTasks;
        private Panel panelTeamsMenu;
        private Button buttonTeamsShowMore;
        private Button buttonTeamsAdd;
        private Button buttonProjectsAdd;
    }
}