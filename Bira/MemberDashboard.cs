using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bira.Services;
using Bira.Models;

namespace Bira
{
    using System.Runtime.InteropServices;

 

    public partial class MemberDashboard : Form
    {
        private readonly ProjectService _projectService = new ProjectService();
        private readonly TeamService _teamService = new TeamService();
        private readonly TaskService _taskService = new TaskService();

        public MemberDashboard()
        {
            InitializeComponent();
            CustomizeSidebar();
            LoadAllData();
        }

        #region Sidebar Logic
        private void CustomizeSidebar()
        {
            panelProjectsMenu.Visible = false;
            panelTeamsMenu.Visible = false;
            panelTasksMenu.Visible = false;
        }

        private void HideSubMenus()
        {
            panelProjectsMenu.Visible = false;
            panelTeamsMenu.Visible = false;
            panelTasksMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                //HideSubMenus(); // optional if you want only one submenu open
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void buttonProjects_Click(object sender, EventArgs e) => ShowSubMenu(panelProjectsMenu);
        private void buttonTeams_Click(object sender, EventArgs e) => ShowSubMenu(panelTeamsMenu);
        private void buttonTasks_Click(object sender, EventArgs e) => ShowSubMenu(panelTasksMenu);
        #endregion

        #region Load Data
        private async void LoadAllData()
        {
            // Load Projects
            var projects = await _projectService.GetProjectsAsync();
            List<string> names = new List<string>();
            foreach (var project in projects)
            {
                names.Add(project.Name);
            }
            await PopulateSubMenu(panelProjectsMenu, buttonProjectsShowMore, projects,names, project =>
            {
                OpenProject(project.ProjectId, project.Name, project.Description, project.StartDate, project.EndDate);
            });
            names.Clear();
            //Load Teams(if needed)
                var teams = await _teamService.GetTeamsAsync();
            foreach (var team in teams)
            {
                names.Add(team.Name);
            }
            await PopulateSubMenu(panelTeamsMenu, buttonTeamsShowMore, teams,names, team =>
            {
                OpenTeam(team.TeamId,team.Name,team.Members);
            });
            names.Clear();
            //Load Tasks(if needed)
                var tasks = await _taskService.GetTasksAsync();
            foreach (var task in tasks)
            {
                names.Add(task.Name);
            }
            await PopulateSubMenu(panelTasksMenu, buttonTasksShowMore, tasks,names, task =>
            {
                OpenTask(task.TaskId,task.Name,task.ProjectName,task.Description,task.startDate,task.endDate,task.Priority,task.Status);
            });
            names.Clear();
        }

        // Generic submenu population for any type (Project, Team, Task)
        private async Task PopulateSubMenu<T>(Panel panel, Button showMoreBtn, List<T> items,List<string>names, Action<T> onClick)
        {
            // Remove existing buttons except "Show More"
            var existing = panel.Controls.OfType<Button>().Where(b => b != showMoreBtn).ToList();
            foreach (var btn in existing)
            {
                panel.Controls.Remove(btn);
                btn.Dispose();
            }

            // Add new buttons for items
            int i = 0;
            foreach (var item in items)

            { 
                Button btn = new Button
                {
                    Dock = DockStyle.Top,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.LightGray,
                    Padding = new Padding(35, 0, 0, 0),
                    Height = 40,
                    Text = names[i].ToString(), // Make sure ToString() gives meaningful text (e.g., project name)
                    TextAlign = ContentAlignment.MiddleLeft
                };
                btn.Click += (s, e) => onClick(item);

                panel.Controls.Add(btn);
                panel.Controls.SetChildIndex(btn, panel.Controls.GetChildIndex(showMoreBtn));
                i++;
            }

            // Ensure "Show More" button stays at bottom
            panel.Controls.SetChildIndex(showMoreBtn, 0);

            await Task.CompletedTask;
        }
        #endregion

        #region Show More Handlers
        private void buttonProjectsShowMore_Click(object sender, EventArgs e) => MessageBox.Show("Load more projects...");
        private void buttonTeamsShowMore_Click(object sender, EventArgs e) => MessageBox.Show("Load more teams...");
        private void buttonTasksShowMore_Click(object sender, EventArgs e) => MessageBox.Show("Load more tasks...");
        #endregion

        #region Item Click Handlers
        private void OpenProject(int projectId, string projectName, string desc, DateTime startDate, DateTime endDate)
        {
            DisplayProjectCard(projectId, projectName, startDate, endDate, desc, Color.FromArgb(52, 152, 219));
        }

        //Example for Teams
        private void OpenTeam(int teamId,string teamName,List<MemberModel>members)
        {
            DisplayTeamCard(teamId,teamName,members, Color.FromArgb(46, 204, 113));
        }

        //Example for Tasks
        private void OpenTask(int taskId,string taskName,string projectName,string desc,DateTime startDate,DateTime endDate,string priority,string status)
        {
            DisplayTaskCard(taskId,taskName,projectName,desc,startDate,endDate,priority,status, Color.FromArgb(231, 76, 60));
        }

        private void DisplayTeamCard(int teamId, string teamName, List<MemberModel> teamMembers, Color color)
        {
            panelMain.Controls.Clear();

            Panel card = new Panel
            {
                Width = panelMain.Width - 20,
                Height = 300,
                BackColor = color,
                Padding = new Padding(15),
                Margin = new Padding(10),
                BorderStyle = BorderStyle.None,
                AutoScroll = true
            };

            card.Region = Region.FromHrgn(
                WinApi.CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20)
            );

            Label lblTeamTitle = new Label
            {
                Text = $"👥 Team: {teamName} (ID: {teamId})",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                Height = 40
            };

            FlowLayoutPanel membersPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                BackColor = Color.FromArgb(50, color)
            };

            foreach (var member in teamMembers)
            {
                Panel memberCard = new Panel
                {
                    Width = 200,
                    Height = 80,
                    BackColor = Color.FromArgb(80, color),
                    Margin = new Padding(5),
                    Padding = new Padding(5)
                };

                memberCard.Region = Region.FromHrgn(
                    WinApi.CreateRoundRectRgn(0, 0, memberCard.Width, memberCard.Height, 15, 15)
                );

                Label lblMemberName = new Label
                {
                    Text = $"👤 {member.Name}",
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.White,
                    Dock = DockStyle.Top,
                    Height = 30
                };

                Label lblMemberRole = new Label
                {
                    Text = $"🔧 {member.Role}",
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    ForeColor = Color.White,
                    Dock = DockStyle.Top,
                    Height = 25
                };

                memberCard.Controls.Add(lblMemberRole);
                memberCard.Controls.Add(lblMemberName);

                membersPanel.Controls.Add(memberCard);
            }

            card.Controls.Add(membersPanel);
            card.Controls.Add(lblTeamTitle);

            panelMain.Controls.Add(card);
        }


        private void DisplayProjectCard(int projectId, string projectName, DateTime startDate, DateTime endDate, string desc, Color color)
        {
            panelMain.Controls.Clear();

            // Card container
            Panel card = new Panel
            {
                Width = panelMain.Width -0,
                Height = 300,
                BackColor = Color.FromArgb(4, 40, 55), // dark theme style
                Padding = new Padding(20),
                Margin = new Padding(15),
                BorderStyle = BorderStyle.None
            };

            // Add rounded corners (simulate with Region)
            card.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20)
            );

            // Title (Project Name)
            Label lblProjectName = new Label
            {
                Text = projectName,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.DeepSkyBlue,
                AutoSize = true,
                Dock = DockStyle.Top,
                Padding = new Padding(0, 0, 0, 10)
            };

            // Project ID (subtitle)
            Label lblProjectId = new Label
            {
                Text = $"Project ID: {projectId}",
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                ForeColor = Color.Silver,
                AutoSize = true,
                Dock = DockStyle.Top,
                Padding = new Padding(0, 0, 0, 10)
            };

            // Dates container
            FlowLayoutPanel datesPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 30,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                WrapContents = false
            };

            Label lblStart = new Label
            {
                Text = $"Start Date: {startDate:dd MMM yyyy}",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.LightGreen,
                AutoSize = true,
                Margin = new Padding(0, 0, 30, 0)
            };

            Label lblEnd = new Label
            {
                Text = $"End Date: {endDate:dd MMM yyyy}",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.IndianRed,
                AutoSize = true
            };

            datesPanel.Controls.Add(lblStart);
            datesPanel.Controls.Add(lblEnd);

            // Description
            TextBox txtDesc = new TextBox
            {
                Text = desc,
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(50, 50, 65),
                Multiline = true,
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill
            };

            // Add in order
            card.Controls.Add(txtDesc);
            card.Controls.Add(datesPanel);
            card.Controls.Add(lblProjectId);
            card.Controls.Add(lblProjectName);

            panelMain.Controls.Add(card);
        }

        // helper for rounded corners
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void DisplayTaskCard(int taskId, string taskName, string projectName,
      string desc, DateTime startDate, DateTime endDate, string priority,
      string status, Color color)
        {
            panelMain.Controls.Clear();

            Panel card = new Panel
            {
                Width = panelMain.Width - 20,
                Height = 220,
                BackColor = color,
                Padding = new Padding(15),
                Margin = new Padding(10),
                BorderStyle = BorderStyle.None
            };

            // Rounded corners
            card.Region = Region.FromHrgn(
                WinApi.CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20)
            );

            FlowLayoutPanel contentPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true
            };

            Label lblTaskName = new Label
            {
                Text = $"📝 {taskName}",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true
            };

            Label lblTaskProject = new Label
            {
                Text = $"📂 Project: {projectName}",
                Font = new Font("Segoe UI", 12, FontStyle.Italic),
                ForeColor = Color.White,
                AutoSize = true
            };

            Label lblTaskDesc = new Label
            {
                Text = $"📖 {desc}",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.White,
                AutoSize = true
            };

            Label lblTaskDates = new Label
            {
                Text = $"⏳ {startDate:dd MMM yyyy} ➝ {endDate:dd MMM yyyy}",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.White,
                AutoSize = true
            };

            Label lblTaskPriority = new Label
            {
                Text = $"⚡ Priority: {priority}",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.Gold,
                AutoSize = true
            };

            Label lblTaskStatus = new Label
            {
                Text = $"✅ Status: {status}",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.LightGreen,
                AutoSize = true
            };

            contentPanel.Controls.Add(lblTaskName);
            contentPanel.Controls.Add(lblTaskProject);
            contentPanel.Controls.Add(lblTaskDesc);
            contentPanel.Controls.Add(lblTaskDates);
            contentPanel.Controls.Add(lblTaskPriority);
            contentPanel.Controls.Add(lblTaskStatus);

            card.Controls.Add(contentPanel);
            panelMain.Controls.Add(card);
        }

        #endregion
    }
    public static class WinApi
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
    }
}
