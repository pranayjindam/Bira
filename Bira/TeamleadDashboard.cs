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



    public partial class TeamleadDashboard : Form
    {
        private readonly ProjectService _projectService = new ProjectService();
        private readonly TeamService _teamService = new TeamService();
        private readonly TaskService _taskService = new TaskService();

        private ContextMenuStrip _contextMenu;
        private int _currentItemId;
        private string _currentItemType;

        private void InitializeContextMenu()
        {
            _contextMenu = new ContextMenuStrip();

            var editItem = new ToolStripMenuItem("✏️ Edit");
            editItem.Click += (s, e) => HandleEdit();

            var deleteItem = new ToolStripMenuItem("🗑️ Delete");
            deleteItem.Click += (s, e) => HandleDelete();

            _contextMenu.Items.AddRange(new ToolStripItem[] { editItem, deleteItem });
        }

        private void HandleEdit()
        {
            switch (_currentItemType)
            {
                case "Project":
                    EditProject(_currentItemId);
                    break;
                case "Team":
                    EditTeam(_currentItemId);
                    break;
                case "Task":
                    EditTask(_currentItemId);
                    break;
            }
        }

        private void HandleDelete()
        {
            switch (_currentItemType)
            {
                case "Project":
                    DeleteProject(_currentItemId);
                    break;
                case "Team":
                    DeleteTeam(_currentItemId);
                    break;
                case "Task":
                    DeleteTask(_currentItemId);
                    break;
            }
        }
        public TeamleadDashboard()
        {
            InitializeComponent();
            CustomizeSidebar();
            InitializeContextMenu();
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

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 2 clicked!");
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
            await PopulateSubMenu(panelProjectsMenu, buttonProjectsShowMore, projects, names, project =>
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
            await PopulateSubMenu(panelTeamsMenu, buttonTeamsShowMore, teams, names, team =>
            {
                OpenTeam(team.TeamId, team.Name, team.Members);
            });
            names.Clear();
            //Load Tasks(if needed)
            var tasks = await _taskService.GetTasksAsync();
            foreach (var task in tasks)
            {
                names.Add(task.Name);
            }
            await PopulateSubMenu(panelTasksMenu, buttonTasksShowMore, tasks, names, task =>
            {
                OpenTask(task.TaskId, task.Name, task.ProjectName, task.Description, task.startDate, task.endDate, task.Priority, task.Status);
            });
            names.Clear();
        }

        // Generic submenu population for any type (Project, Team, Task)
        private async Task PopulateSubMenu<T>(
     Panel panel, Button showMoreBtn,
     List<T> items, List<string> names,
     Action<T> onClick)
        {
            // Clear old dynamic items
            var existing = panel.Controls.OfType<Panel>()
                .Where(p => p.Tag?.ToString() == "DynamicItem")
                .ToList();

            foreach (var ctrl in existing)
            {
                panel.Controls.Remove(ctrl);
                ctrl.Dispose();
            }

            int i = 0;
            foreach (var item in items)
            {
                int itemId = 0;
                string itemType = "";

                // Safe type checks
                if (item is ProjectModel project)
                {
                    itemId = project.ProjectId;
                    itemType = "Project";
                }
                else if (item is TeamModel team)
                {
                    itemId = team.TeamId;
                    itemType = "Team";
                }
                else if (item is TaskModel task)
                {
                    itemId = task.TaskId;
                    itemType = "Task";
                }

                Panel pn = new Panel
                {
                    Size = new Size(panel.Width - 5, 40),
                    Dock = DockStyle.Top,
                    Tag = "DynamicItem",
                  
                };

                // Main button
                Button btn = new Button
                {
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.LightGray,
                    Text = names[i],
                    TextAlign = ContentAlignment.MiddleLeft,
                    //Dock = DockStyle.Top,
                    Margin = new Padding(20, 0, 0, 10)


                };
                btn.Click += (s, e) => onClick(item);

                // 3-dot button
                Button btn2 = new Button
                {
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.LightGray,
                    Text = "⋮", // vertical ellipsis
                    Width = 40,
                    Dock = DockStyle.Right,
                    Tag = new Tuple<int, string>(itemId, itemType) // store safely
                };
                btn2.Click += Btn2_Click;

                pn.Controls.Add(btn);
                pn.Controls.Add(btn2);
                panel.Controls.Add(pn);

                panel.Controls.SetChildIndex(pn, 0);
                i++;
            }

            await Task.CompletedTask;
        }

        private void EditProject(int projectId) => MessageBox.Show($"Edit Project {projectId}");
        private void DeleteProject(int projectId) => MessageBox.Show($"Delete Project {projectId}");

        private void EditTeam(int teamId) => MessageBox.Show($"Edit Team {teamId}");
        private void DeleteTeam(int teamId) => MessageBox.Show($"Delete Team {teamId}");

        private void EditTask(int taskId) => MessageBox.Show($"Edit Task {taskId}");
        private void DeleteTask(int taskId) => MessageBox.Show($"Delete Task {taskId}");


      


        private void Btn2_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Tuple<int, string> info)
            {
                _currentItemId = info.Item1;
                _currentItemType = info.Item2;

                _contextMenu.Show(btn, new Point(0, btn.Height));
            }
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
        private void OpenTeam(int teamId, string teamName, List<MemberModel> members)
        {
            DisplayTeamCard(teamId, teamName, members, Color.FromArgb(46, 204, 113));
        }

        //Example for Tasks
        private void OpenTask(int taskId, string taskName, string projectName, string desc, DateTime startDate, DateTime endDate, string priority, string status)
        {
            DisplayTaskCard(taskId, taskName, projectName, desc, startDate, endDate, priority, status, Color.FromArgb(231, 76, 60));
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
                Width = panelMain.Width - 0,
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
    //public static class WinApi
    //{
    //    [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    //    public static extern IntPtr CreateRoundRectRgn(
    //        int nLeftRect,
    //        int nTopRect,
    //        int nRightRect,
    //        int nBottomRect,
    //        int nWidthEllipse,
    //        int nHeightEllipse
    //    );
    //}
}
