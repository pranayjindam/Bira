using System.Windows.Forms;
using Bira;
using Bira.UI;

namespace Bira
{
    partial class TeamleadDashboard
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
            panelMain = new RoundedPanel();
            panelSidebar = new RoundedPanel();
            buttonLogout = new Button();
            panelBacklogs = new Panel();
            pictureBox4 = new PictureBox();
            buttonBacklogs = new Button();
            panelTasksMenu = new Panel();
            buttonTasksShowMore = new Button();
            panelTasks = new Panel();
            buttonTasksAdd = new Button();
            pictureBox3 = new PictureBox();
            buttonTasks = new Button();
            panelTeamsMenu = new Panel();
            buttonTeamsShowMore = new Button();
            panelTeams = new Panel();
            buttonTeamsAdd = new Button();
            pictureBox2 = new PictureBox();
            buttonTeams = new Button();
            panelProjectsMenu = new Panel();
            buttonProjectsShowMore = new Button();
            panelProjects = new Panel();
            buttonProjectsAdd = new Button();
            pictureBox1 = new PictureBox();
            buttonProjects = new Button();
            panelForyou = new Panel();
            pictureBox5 = new PictureBox();
            buttonForyou = new Button();
            panelLogo = new Panel();
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            panelSidebar.SuspendLayout();
            panelBacklogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelTasksMenu.SuspendLayout();
            panelTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelTeamsMenu.SuspendLayout();
            panelTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelProjectsMenu.SuspendLayout();
            panelProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelForyou.SuspendLayout();
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
            panelSidebar.Controls.Add(panelBacklogs);
            panelSidebar.Controls.Add(panelTasksMenu);
            panelSidebar.Controls.Add(panelTasks);
            panelSidebar.Controls.Add(panelTeamsMenu);
            panelSidebar.Controls.Add(panelTeams);
            panelSidebar.Controls.Add(panelProjectsMenu);
            panelSidebar.Controls.Add(panelProjects);
            panelSidebar.Controls.Add(panelForyou);
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
            buttonLogout.TabIndex = 14;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // panelBacklogs
            // 
            panelBacklogs.Controls.Add(pictureBox4);
            panelBacklogs.Controls.Add(buttonBacklogs);
            panelBacklogs.Dock = DockStyle.Top;
            panelBacklogs.Location = new Point(0, 425);
            panelBacklogs.Name = "panelBacklogs";
            panelBacklogs.Padding = new Padding(15, 0, 0, 0);
            panelBacklogs.Size = new Size(280, 45);
            panelBacklogs.TabIndex = 13;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.backlogs_icon;
            pictureBox4.Location = new Point(20, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // buttonBacklogs
            // 
            buttonBacklogs.Dock = DockStyle.Fill;
            buttonBacklogs.FlatAppearance.BorderSize = 0;
            buttonBacklogs.FlatStyle = FlatStyle.Flat;
            buttonBacklogs.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonBacklogs.ForeColor = Color.FromArgb(156, 163, 175);
            buttonBacklogs.Location = new Point(15, 0);
            buttonBacklogs.Name = "buttonBacklogs";
            buttonBacklogs.Padding = new Padding(40, 0, 0, 0);
            buttonBacklogs.Size = new Size(265, 45);
            buttonBacklogs.TabIndex = 3;
            buttonBacklogs.Text = "Backlogs";
            buttonBacklogs.TextAlign = ContentAlignment.MiddleLeft;
            buttonBacklogs.Click += buttonBacklogs_Click;
            // 
            // panelTasksMenu
            // 
            panelTasksMenu.AutoSize = true;
            panelTasksMenu.BackColor = Color.FromArgb(31, 41, 55);
            panelTasksMenu.Controls.Add(buttonTasksShowMore);
            panelTasksMenu.Dock = DockStyle.Top;
            panelTasksMenu.Location = new Point(0, 380);
            panelTasksMenu.Name = "panelTasksMenu";
            panelTasksMenu.Size = new Size(280, 45);
            panelTasksMenu.TabIndex = 12;
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
            panelTasks.Controls.Add(buttonTasksAdd);
            panelTasks.Controls.Add(pictureBox3);
            panelTasks.Controls.Add(buttonTasks);
            panelTasks.Dock = DockStyle.Top;
            panelTasks.Location = new Point(0, 335);
            panelTasks.Name = "panelTasks";
            panelTasks.Padding = new Padding(15, 0, 0, 0);
            panelTasks.Size = new Size(280, 45);
            panelTasks.TabIndex = 11;
            // 
            // buttonTasksAdd
            // 
            buttonTasksAdd.Dock = DockStyle.Right;
            buttonTasksAdd.FlatAppearance.BorderSize = 0;
            buttonTasksAdd.FlatStyle = FlatStyle.Flat;
            buttonTasksAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonTasksAdd.ForeColor = Color.FromArgb(16, 185, 129);
            buttonTasksAdd.Location = new Point(230, 0);
            buttonTasksAdd.Name = "buttonTasksAdd";
            buttonTasksAdd.Size = new Size(50, 45);
            buttonTasksAdd.TabIndex = 9;
            buttonTasksAdd.Text = "+";
            buttonTasksAdd.UseVisualStyleBackColor = true;
            buttonTasksAdd.Click += buttonTasksAdd_Click;
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
            panelTeamsMenu.Location = new Point(0, 290);
            panelTeamsMenu.Name = "panelTeamsMenu";
            panelTeamsMenu.Size = new Size(280, 45);
            panelTeamsMenu.TabIndex = 10;
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
            panelTeams.Controls.Add(buttonTeamsAdd);
            panelTeams.Controls.Add(pictureBox2);
            panelTeams.Controls.Add(buttonTeams);
            panelTeams.Dock = DockStyle.Top;
            panelTeams.Location = new Point(0, 245);
            panelTeams.Name = "panelTeams";
            panelTeams.Padding = new Padding(15, 0, 0, 0);
            panelTeams.Size = new Size(280, 45);
            panelTeams.TabIndex = 9;
            // 
            // buttonTeamsAdd
            // 
            buttonTeamsAdd.Dock = DockStyle.Right;
            buttonTeamsAdd.FlatAppearance.BorderSize = 0;
            buttonTeamsAdd.FlatStyle = FlatStyle.Flat;
            buttonTeamsAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonTeamsAdd.ForeColor = Color.FromArgb(16, 185, 129);
            buttonTeamsAdd.Location = new Point(230, 0);
            buttonTeamsAdd.Name = "buttonTeamsAdd";
            buttonTeamsAdd.Size = new Size(50, 45);
            buttonTeamsAdd.TabIndex = 9;
            buttonTeamsAdd.Text = "+";
            buttonTeamsAdd.UseVisualStyleBackColor = true;
            buttonTeamsAdd.Click += buttonTeamsAdd_Click;
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
            panelProjectsMenu.Location = new Point(0, 200);
            panelProjectsMenu.Name = "panelProjectsMenu";
            panelProjectsMenu.Size = new Size(280, 45);
            panelProjectsMenu.TabIndex = 8;
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
            panelProjects.Controls.Add(buttonProjectsAdd);
            panelProjects.Controls.Add(pictureBox1);
            panelProjects.Controls.Add(buttonProjects);
            panelProjects.Dock = DockStyle.Top;
            panelProjects.Location = new Point(0, 155);
            panelProjects.Name = "panelProjects";
            panelProjects.Padding = new Padding(15, 0, 0, 0);
            panelProjects.Size = new Size(280, 45);
            panelProjects.TabIndex = 7;
            // 
            // buttonProjectsAdd
            // 
            buttonProjectsAdd.Dock = DockStyle.Right;
            buttonProjectsAdd.FlatAppearance.BorderSize = 0;
            buttonProjectsAdd.FlatStyle = FlatStyle.Flat;
            buttonProjectsAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonProjectsAdd.ForeColor = Color.FromArgb(16, 185, 129);
            buttonProjectsAdd.Location = new Point(230, 0);
            buttonProjectsAdd.Name = "buttonProjectsAdd";
            buttonProjectsAdd.Size = new Size(50, 45);
            buttonProjectsAdd.TabIndex = 9;
            buttonProjectsAdd.Text = "+";
            buttonProjectsAdd.UseVisualStyleBackColor = true;
            buttonProjectsAdd.Click += buttonProjectsAdd_Click;
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
            // panelForyou
            // 
            panelForyou.Controls.Add(pictureBox5);
            panelForyou.Controls.Add(buttonForyou);
            panelForyou.Dock = DockStyle.Top;
            panelForyou.Location = new Point(0, 110);
            panelForyou.Name = "panelForyou";
            panelForyou.Padding = new Padding(15, 0, 0, 0);
            panelForyou.Size = new Size(280, 45);
            panelForyou.TabIndex = 6;
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
            // buttonForyou
            // 
            buttonForyou.Dock = DockStyle.Fill;
            buttonForyou.FlatAppearance.BorderSize = 0;
            buttonForyou.FlatStyle = FlatStyle.Flat;
            buttonForyou.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonForyou.ForeColor = Color.FromArgb(156, 163, 175);
            buttonForyou.Location = new Point(15, 0);
            buttonForyou.Name = "buttonForyou";
            buttonForyou.Padding = new Padding(40, 0, 0, 0);
            buttonForyou.Size = new Size(265, 45);
            buttonForyou.TabIndex = 7;
            buttonForyou.Text = "Overview";
            buttonForyou.TextAlign = ContentAlignment.MiddleLeft;
            buttonForyou.Click += buttonForyou_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(280, 110);
            panelLogo.TabIndex = 15;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.bira_logo;
            pictureBoxLogo.Location = new Point(35, 35);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(39, 54);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(37, 99, 235);
            label1.Location = new Point(80, 35);
            label1.Name = "label1";
            label1.Size = new Size(138, 54);
            label1.TabIndex = 0;
            label1.Text = "BIRA";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TeamleadDashboard
            // 
            ClientSize = new Size(1300, 749);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "TeamleadDashboard";
            Text = "TeamLead Dashboard";
            WindowState = FormWindowState.Maximized;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelBacklogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelTasksMenu.ResumeLayout(false);
            panelTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelTeamsMenu.ResumeLayout(false);
            panelTeams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelProjectsMenu.ResumeLayout(false);
            panelProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelForyou.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Bira.RoundedPanel panelSidebar;
        private Panel panelForyou;
        private Panel panelTeams;
        private Button buttonTeams;
        private Panel panelProjectsMenu;
        private Panel panelProjects;
        private Button buttonProjects;
        private Button buttonForyou;
        private Panel panelTasksMenu;
        private Panel panelTasks;
        private Button buttonTasks;
        private Panel panelTeamsMenu;
        private Panel panelBacklogs;
        private Button buttonBacklogs;
        private Button buttonLogout;
        private Panel panelLogo;
        private Label label1;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button buttonProjectsShowMore;
        private Button buttonTeamsShowMore;
        private Button buttonTasksShowMore;
        private Button buttonProjectsAdd;
        private Button buttonTeamsAdd;
        private Button buttonTasksAdd;
        private RoundedPanel panelMain;
    }
}