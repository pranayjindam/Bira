using Bira.UI;

namespace Bira
{
    partial class MemberDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMain = new Panel();
            panelSidebar = new RoundedPanel();
            buttonLogout = new Button();
            panelTasksMenu = new Panel();
            buttonTasksShowMore = new Button();
            panelTasks = new Panel();
            pictureBox3 = new PictureBox();
            buttonTasks = new Button();
            panelTeamsMenu = new Panel();
            buttonTeamsShowMore = new Button();
            panelTeams = new Panel();
            pictureBox2 = new PictureBox();
            buttonTeams = new Button();
            panelProjectsMenu = new Panel();
            buttonProjectsShowMore = new Button();
            panelProjects = new Panel();
            pictureBox1 = new PictureBox();
            buttonProjects = new Button();
            panelOverview = new Panel();
            pictureBox5 = new PictureBox();
            buttonOverview = new Button();
            panelLogo = new Panel();
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            panelSidebar.SuspendLayout();
            panelTasksMenu.SuspendLayout();
            panelTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelTeamsMenu.SuspendLayout();
            panelTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelProjectsMenu.SuspendLayout();
            panelProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(280, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(10);
            panelMain.Size = new Size(1020, 749);
            panelMain.TabIndex = 0;
            // 
            // panelSidebar
            // 
            panelSidebar.AutoScroll = true;
            panelSidebar.BackColor = Color.Black;
            panelSidebar.Controls.Add(buttonLogout);
            panelSidebar.Controls.Add(panelTasksMenu);
            panelSidebar.Controls.Add(panelTasks);
            panelSidebar.Controls.Add(panelTeamsMenu);
            panelSidebar.Controls.Add(panelTeams);
            panelSidebar.Controls.Add(panelProjectsMenu);
            panelSidebar.Controls.Add(panelProjects);
            panelSidebar.Controls.Add(panelOverview);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.CornerRadius = 40;
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(280, 749);
            panelSidebar.TabIndex = 1;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(220, 53, 69);
            buttonLogout.Dock = DockStyle.Bottom;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(0, 708);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(280, 41);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // panelTasksMenu
            // 
            panelTasksMenu.AutoSize = true;
            panelTasksMenu.BackColor = Color.FromArgb(31, 41, 55);
            panelTasksMenu.Controls.Add(buttonTasksShowMore);
            panelTasksMenu.Dock = DockStyle.Top;
            panelTasksMenu.Location = new Point(0, 346);
            panelTasksMenu.Name = "panelTasksMenu";
            panelTasksMenu.Size = new Size(280, 45);
            panelTasksMenu.TabIndex = 11;
            // 
            // buttonTasksShowMore
            // 
            buttonTasksShowMore.Dock = DockStyle.Bottom;
            buttonTasksShowMore.FlatAppearance.BorderSize = 0;
            buttonTasksShowMore.FlatStyle = FlatStyle.Flat;
            buttonTasksShowMore.Font = new Font("Segoe UI", 9F);
            buttonTasksShowMore.ForeColor = Color.FromArgb(107, 114, 128);
            buttonTasksShowMore.Location = new Point(0, 0);
            buttonTasksShowMore.Name = "buttonTasksShowMore";
            buttonTasksShowMore.Padding = new Padding(35, 0, 0, 0);
            buttonTasksShowMore.Size = new Size(280, 45);
            buttonTasksShowMore.TabIndex = 0;
            buttonTasksShowMore.Text = "Show More";
            buttonTasksShowMore.TextAlign = ContentAlignment.MiddleLeft;
            buttonTasksShowMore.Click += buttonTasksShowMore_Click;
            // 
            // panelTasks
            // 
            panelTasks.Controls.Add(pictureBox3);
            panelTasks.Controls.Add(buttonTasks);
            panelTasks.Dock = DockStyle.Top;
            panelTasks.Location = new Point(0, 301);
            panelTasks.Name = "panelTasks";
            panelTasks.Padding = new Padding(15, 0, 0, 0);
            panelTasks.Size = new Size(280, 45);
            panelTasks.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.tasks_icon;
            pictureBox3.Location = new Point(20, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // buttonTasks
            // 
            buttonTasks.Dock = DockStyle.Fill;
            buttonTasks.FlatAppearance.BorderSize = 0;
            buttonTasks.FlatStyle = FlatStyle.Flat;
            buttonTasks.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonTasks.ForeColor = Color.FromArgb(156, 163, 175);
            buttonTasks.Location = new Point(15, 0);
            buttonTasks.Name = "buttonTasks";
            buttonTasks.Padding = new Padding(40, 0, 0, 0);
            buttonTasks.Size = new Size(265, 45);
            buttonTasks.TabIndex = 2;
            buttonTasks.Text = "Tasks";
            buttonTasks.TextAlign = ContentAlignment.MiddleLeft;
            buttonTasks.Click += buttonTasks_Click;
            // 
            // panelTeamsMenu
            // 
            panelTeamsMenu.AutoSize = true;
            panelTeamsMenu.BackColor = Color.FromArgb(31, 41, 55);
            panelTeamsMenu.Controls.Add(buttonTeamsShowMore);
            panelTeamsMenu.Dock = DockStyle.Top;
            panelTeamsMenu.Location = new Point(0, 256);
            panelTeamsMenu.Name = "panelTeamsMenu";
            panelTeamsMenu.Size = new Size(280, 45);
            panelTeamsMenu.TabIndex = 9;
            // 
            // buttonTeamsShowMore
            // 
            buttonTeamsShowMore.Dock = DockStyle.Bottom;
            buttonTeamsShowMore.FlatAppearance.BorderSize = 0;
            buttonTeamsShowMore.FlatStyle = FlatStyle.Flat;
            buttonTeamsShowMore.Font = new Font("Segoe UI", 9F);
            buttonTeamsShowMore.ForeColor = Color.FromArgb(107, 114, 128);
            buttonTeamsShowMore.Location = new Point(0, 0);
            buttonTeamsShowMore.Name = "buttonTeamsShowMore";
            buttonTeamsShowMore.Padding = new Padding(35, 0, 0, 0);
            buttonTeamsShowMore.Size = new Size(280, 45);
            buttonTeamsShowMore.TabIndex = 0;
            buttonTeamsShowMore.Text = "Show More";
            buttonTeamsShowMore.TextAlign = ContentAlignment.MiddleLeft;
            buttonTeamsShowMore.Click += buttonTeamsShowMore_Click;
            // 
            // panelTeams
            // 
            panelTeams.Controls.Add(pictureBox2);
            panelTeams.Controls.Add(buttonTeams);
            panelTeams.Dock = DockStyle.Top;
            panelTeams.Location = new Point(0, 211);
            panelTeams.Name = "panelTeams";
            panelTeams.Padding = new Padding(15, 0, 0, 0);
            panelTeams.Size = new Size(280, 45);
            panelTeams.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.teams_icon;
            pictureBox2.Location = new Point(20, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // buttonTeams
            // 
            buttonTeams.Dock = DockStyle.Fill;
            buttonTeams.FlatAppearance.BorderSize = 0;
            buttonTeams.FlatStyle = FlatStyle.Flat;
            buttonTeams.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonTeams.ForeColor = Color.FromArgb(156, 163, 175);
            buttonTeams.Location = new Point(15, 0);
            buttonTeams.Name = "buttonTeams";
            buttonTeams.Padding = new Padding(40, 0, 0, 0);
            buttonTeams.Size = new Size(265, 45);
            buttonTeams.TabIndex = 8;
            buttonTeams.Text = "Teams";
            buttonTeams.TextAlign = ContentAlignment.MiddleLeft;
            buttonTeams.Click += buttonTeams_Click;
            // 
            // panelProjectsMenu
            // 
            panelProjectsMenu.AutoSize = true;
            panelProjectsMenu.BackColor = Color.FromArgb(31, 41, 55);
            panelProjectsMenu.Controls.Add(buttonProjectsShowMore);
            panelProjectsMenu.Dock = DockStyle.Top;
            panelProjectsMenu.Location = new Point(0, 166);
            panelProjectsMenu.Name = "panelProjectsMenu";
            panelProjectsMenu.Size = new Size(280, 45);
            panelProjectsMenu.TabIndex = 7;
            // 
            // buttonProjectsShowMore
            // 
            buttonProjectsShowMore.Dock = DockStyle.Bottom;
            buttonProjectsShowMore.FlatAppearance.BorderSize = 0;
            buttonProjectsShowMore.FlatStyle = FlatStyle.Flat;
            buttonProjectsShowMore.Font = new Font("Segoe UI", 9F);
            buttonProjectsShowMore.ForeColor = Color.FromArgb(107, 114, 128);
            buttonProjectsShowMore.Location = new Point(0, 0);
            buttonProjectsShowMore.Name = "buttonProjectsShowMore";
            buttonProjectsShowMore.Padding = new Padding(35, 0, 0, 0);
            buttonProjectsShowMore.Size = new Size(280, 45);
            buttonProjectsShowMore.TabIndex = 0;
            buttonProjectsShowMore.Text = "Show More";
            buttonProjectsShowMore.TextAlign = ContentAlignment.MiddleLeft;
            buttonProjectsShowMore.Click += buttonProjectsShowMore_Click;
            // 
            // panelProjects
            // 
            panelProjects.Controls.Add(pictureBox1);
            panelProjects.Controls.Add(buttonProjects);
            panelProjects.Dock = DockStyle.Top;
            panelProjects.Location = new Point(0, 121);
            panelProjects.Name = "panelProjects";
            panelProjects.Padding = new Padding(15, 0, 0, 0);
            panelProjects.Size = new Size(280, 45);
            panelProjects.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.projects_icon;
            pictureBox1.Location = new Point(20, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // buttonProjects
            // 
            buttonProjects.Dock = DockStyle.Fill;
            buttonProjects.FlatAppearance.BorderSize = 0;
            buttonProjects.FlatStyle = FlatStyle.Flat;
            buttonProjects.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonProjects.ForeColor = Color.FromArgb(156, 163, 175);
            buttonProjects.Location = new Point(15, 0);
            buttonProjects.Name = "buttonProjects";
            buttonProjects.Padding = new Padding(40, 0, 0, 0);
            buttonProjects.Size = new Size(265, 45);
            buttonProjects.TabIndex = 7;
            buttonProjects.Text = "Projects";
            buttonProjects.TextAlign = ContentAlignment.MiddleLeft;
            buttonProjects.Click += buttonProjects_Click;
            // 
            // panelOverview
            // 
            panelOverview.Controls.Add(pictureBox5);
            panelOverview.Controls.Add(buttonOverview);
            panelOverview.Dock = DockStyle.Top;
            panelOverview.Location = new Point(0, 76);
            panelOverview.Name = "panelOverview";
            panelOverview.Padding = new Padding(15, 0, 0, 0);
            panelOverview.Size = new Size(280, 45);
            panelOverview.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.overview_icon;
            pictureBox5.Location = new Point(20, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // buttonOverview
            // 
            buttonOverview.Dock = DockStyle.Fill;
            buttonOverview.FlatAppearance.BorderSize = 0;
            buttonOverview.FlatStyle = FlatStyle.Flat;
            buttonOverview.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonOverview.ForeColor = Color.FromArgb(156, 163, 175);
            buttonOverview.Location = new Point(15, 0);
            buttonOverview.Name = "buttonOverview";
            buttonOverview.Padding = new Padding(40, 0, 0, 0);
            buttonOverview.Size = new Size(265, 45);
            buttonOverview.TabIndex = 7;
            buttonOverview.Text = "Overview";
            buttonOverview.TextAlign = ContentAlignment.MiddleLeft;
            buttonOverview.Click += buttonOverview_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(280, 76);
            panelLogo.TabIndex = 13;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.bira_logo;
            pictureBoxLogo.Location = new Point(38, 9);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(39, 54);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(1, 73, 124);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 54);
            label1.TabIndex = 0;
            label1.Text = "BIRA";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MemberDashboard
            // 
            ClientSize = new Size(1300, 749);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "MemberDashboard";
            Text = "Member Dashboard";
            WindowState = FormWindowState.Maximized;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelTasksMenu.ResumeLayout(false);
            panelTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelTeamsMenu.ResumeLayout(false);
            panelTeams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelProjectsMenu.ResumeLayout(false);
            panelProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel panelSidebar;
        private Panel panelMain;
        private Panel panelOverview;
        private Panel panelProjects;
        private Button buttonProjects;
        private Button buttonOverview;
        private Panel panelProjectsMenu;
        private Panel panelTasks;
        private Button buttonTasks;
        private Panel panelTeams;
        private Button buttonTeams;
        private Panel panelTeamsMenu;
        private Panel panelTasksMenu;
        private Button buttonLogout;
        private Panel panelLogo;
        private Label label1;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Button buttonProjectsShowMore;
        private Button buttonTeamsShowMore;
        private Button buttonTasksShowMore;
    }
}