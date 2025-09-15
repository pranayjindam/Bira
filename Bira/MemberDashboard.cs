using Bira.Models;
using Bira.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bira
{
    using Bira.Naveen;
    using System.Runtime.InteropServices;



    public partial class MemberDashboard : Form
    {
        private readonly ProjectService _projectService = new ProjectService();
        private readonly TeamService _teamService = new TeamService();
        private readonly TaskService _taskService = new TaskService();
        private static readonly Random _rnd = new Random();
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
                HideSubMenus(); // optional if you want only one submenu open
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
        private async Task PopulateSubMenu<T>(Panel panel, Button showMoreBtn, List<T> items, List<string> names, Action<T> onClick)
        {
            // Remove existing buttons except "Show More"
            var existing = panel.Controls.OfType<Button>().Where(b => b != showMoreBtn).ToList();
            foreach (var btn in existing)
            {
                panel.Controls.Remove(btn);
                btn.Dispose();
            }

            // Define colors
            Color defaultBack = Color.Transparent;
            Color hoverBack = Color.FromArgb(28, 151, 234);   // Dark gray
            Color activeBack = Color.FromArgb(28, 151, 234); // Blue

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
                    Text = names[i].ToString(),
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = defaultBack,
                    Tag = "inactive" // track active state
                };

                // Hover events
                btn.MouseEnter += (s, e) =>
                {
                    if (btn.Tag.ToString() != "active")
                        btn.BackColor = hoverBack;
                };

                btn.MouseLeave += (s, e) =>
                {
                    if (btn.Tag.ToString() != "active")
                        btn.BackColor = defaultBack;
                };

                // Click (active state)
                btn.Click += (s, e) =>
                {
                    // Reset all buttons in panel to default
                    foreach (Control c in panel.Controls.OfType<Button>())
                    {
                        if (c != showMoreBtn)
                        {
                            c.Tag = "inactive";
                            c.BackColor = defaultBack;
                        }
                    }

                    // Mark this one active
                    btn.Tag = "active";
                    btn.BackColor = activeBack;

                    // Call provided click action
                    onClick(item);
                };

                panel.Controls.Add(btn);
                panel.Controls.SetChildIndex(btn, panel.Controls.GetChildIndex(showMoreBtn));
                i++;
            }

            // Ensure "Show More" button stays at bottom
            panel.Controls.SetChildIndex(showMoreBtn, 0);

            await Task.CompletedTask;
        }

        #endregion
        private Panel CreateAvatar(string name, Color bgColor)
        {
            Panel avatar = new Panel
            {
                Width = 50,
                Height = 50,
                BackColor = bgColor,
                Margin = new Padding(10),
            };

            avatar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, avatar.Width, avatar.Height, 50, 50));

            Label lbl = new Label
            {
                Text = string.IsNullOrEmpty(name) ? "?" : name.Substring(0, 1).ToUpper(),
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };

            avatar.Controls.Add(lbl);
            return avatar;
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(_rnd.Next(100, 256), _rnd.Next(100, 256), _rnd.Next(100, 256));
        }
        private void Card_ClickHandler(Panel card)
        {
            if (card.Tag is ProjectModel p)
                OpenProject(p.ProjectId, p.Name, p.Description, p.StartDate, p.EndDate);
            else if (card.Tag is TeamModel t)
                OpenTeam(t.TeamId, t.Name, t.Members);
            else if (card.Tag is TaskModel task)
                OpenTask(task.TaskId, task.Name, task.ProjectName, task.Description, task.startDate, task.endDate, task.Priority, task.Status);
        }
        #region Show More Handlers
        private async void buttonProjectsShowMore_Click(object sender, EventArgs e)
        {
            var projects = await _projectService.GetProjectsAsync();

            panelMain.Controls.Clear();

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true
            };

            foreach (var project in projects)
            {
                Panel card = new Panel
                {
                    Width = 250,
                    Height = 180,
                    BackColor = Color.FromArgb(40, 40, 60),
                    Margin = new Padding(10),
                    Padding = new Padding(10),
                    Cursor = Cursors.Hand,
                    Tag = project // store full object for later use
                };

                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 15, 15));

                // Avatar
                Panel avatar = CreateAvatar(project.Name, GetRandomColor());

                Label lblName = new Label
                {
                    Text = project.Name,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    ForeColor = Color.DeepSkyBlue,
                    Dock = DockStyle.Top
                };

                Label lblDates = new Label
                {
                    Text = $"{project.StartDate:dd MMM} ➝ {project.EndDate:dd MMM}",
                    Font = new Font("Segoe UI", 9),
                    ForeColor = Color.LightGray,
                    Dock = DockStyle.Top
                };

                Label lblDesc = new Label
                {
                    Text = project.Description,
                    Font = new Font("Segoe UI", 9),
                    ForeColor = Color.White,
                    Dock = DockStyle.Fill,
                    AutoEllipsis = true
                };

                card.Controls.Add(lblDesc);
                card.Controls.Add(lblDates);
                card.Controls.Add(lblName);
                card.Controls.Add(avatar);

                // 🔹 Card Click → OpenProject
                card.Click += (s, ev) =>
                {
                    var p = (ProjectModel)((Panel)s).Tag;
                    OpenProject(p.ProjectId, p.Name, p.Description, p.StartDate, p.EndDate);
                };

                // 🔹 Make inner labels clickable too
                foreach (Control ctrl in card.Controls)
                {
                    ctrl.Click += (s, ev) => Card_ClickHandler(card);
                }


                flow.Controls.Add(card);
            }

            panelMain.Controls.Add(flow);
        }

        private async void buttonTeamsShowMore_Click(object sender, EventArgs e)
        {
            var teams = await _teamService.GetTeamsAsync();

            panelMain.Controls.Clear();
            FlowLayoutPanel flow = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoScroll = true, WrapContents = true };

            foreach (var team in teams)
            {
                Panel card = new Panel
                {
                    Width = 250,
                    Height = 150,
                    BackColor = Color.FromArgb(30, 80, 50),
                    Margin = new Padding(10),
                    Padding = new Padding(10),
                    Cursor = Cursors.Hand,
                    Tag = team
                };

                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 15, 15));

                Panel avatar = CreateAvatar(team.Name, GetRandomColor());
                Label lblName = new Label { Text = team.Name, Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top };
                Label lblCount = new Label { Text = $"Members: {team.Members.Count}", Font = new Font("Segoe UI", 9), ForeColor = Color.LightGray, Dock = DockStyle.Top };

                card.Controls.Add(lblCount);
                card.Controls.Add(lblName);
                card.Controls.Add(avatar);

                // 🔹 Card Click → OpenTeam
                card.Click += (s, ev) =>
                {
                    var t = (TeamModel)((Panel)s).Tag;
                    OpenTeam(t.TeamId, t.Name, t.Members);
                };
                foreach (Control ctrl in card.Controls)
                {
                    ctrl.Click += (s, ev) => Card_ClickHandler(card);
                }


                flow.Controls.Add(card);
            }

            panelMain.Controls.Add(flow);
        }
        private async void buttonTasksShowMore_Click(object sender, EventArgs e)
        {
            var tasks = await _taskService.GetTasksAsync();

            panelMain.Controls.Clear();
            FlowLayoutPanel flow = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoScroll = true, WrapContents = true };

            foreach (var task in tasks)
            {
                Panel card = new Panel
                {
                    Width = 250,
                    Height = 170,
                    BackColor = Color.FromArgb(80, 40, 40),
                    Margin = new Padding(10),
                    Padding = new Padding(10),
                    Cursor = Cursors.Hand,
                    Tag = task
                };

                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 15, 15));

                Panel avatar = CreateAvatar(task.Name, GetRandomColor());
                Label lblName = new Label { Text = task.Name, Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top };
                Label lblProject = new Label { Text = $"📂 {task.ProjectName}", Font = new Font("Segoe UI", 9), ForeColor = Color.LightGray, Dock = DockStyle.Top };
                Label lblStatus = new Label { Text = $"✅ {task.Status}", Font = new Font("Segoe UI", 9), ForeColor = Color.LightGreen, Dock = DockStyle.Top };

                card.Controls.Add(lblStatus);
                card.Controls.Add(lblProject);
                card.Controls.Add(lblName);
                card.Controls.Add(avatar);

                // 🔹 Card Click → OpenTask
                card.Click += (s, ev) =>
                {
                    var t = (TaskModel)((Panel)s).Tag;
                    OpenTask(t.TaskId, t.Name, t.ProjectName, t.Description, t.startDate, t.endDate, t.Priority, t.Status);
                };
                foreach (Control ctrl in card.Controls)
                {
                    ctrl.Click += (s, ev) => Card_ClickHandler(card);
                }


                flow.Controls.Add(card);
            }

            panelMain.Controls.Add(flow);
        }
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
                BackColor = Color.FromArgb(4, 40, 55),
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

            // Rounded corners
            card.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20)
            );
            card.Resize += (s, e) =>
            {
                card.Region = System.Drawing.Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20)
                );
            };

            // 🔹 Layout to center everything
            TableLayoutPanel layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                BackColor = Color.Transparent
            };

            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Project Name
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Project ID
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Dates
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); // Description (fills)

            layout.Padding = new Padding(0);
            layout.Margin = new Padding(0);

            // 🔹 Title
            Label lblProjectName = new Label
            {
                Text = $"📁 {projectName}",
                Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold),
                ForeColor = Color.DeepSkyBlue,
                AutoSize = true,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // 🔹 Project ID
            Label lblProjectId = new Label
            {
                Text = $"🔑 Project ID: {projectId}",
                Font = new Font("Segoe UI Emoji", 12, FontStyle.Italic),
                ForeColor = Color.Silver,
                AutoSize = true,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // 🔹 Dates
            FlowLayoutPanel datesPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                Anchor = AnchorStyles.None,
                WrapContents = false,
                BackColor = Color.Transparent,
                Margin = new Padding(0, 10, 0, 10)
            };

            Label lblStart = new Label
            {
                Text = $"🟢 Start: {startDate:dd MMM yyyy}",
                Font = new Font("Segoe UI Emoji", 12, FontStyle.Regular),
                ForeColor = Color.LightGreen,
                AutoSize = true
            };

            Label lblEnd = new Label
            {
                Text = $"⏰ End: {endDate:dd MMM yyyy}",
                Font = new Font("Segoe UI Emoji", 12, FontStyle.Regular),
                ForeColor = Color.IndianRed,
                AutoSize = true,
                Margin = new Padding(20, 0, 0, 0)
            };

            datesPanel.Controls.Add(lblStart);
            datesPanel.Controls.Add(lblEnd);

            // 🔹 Description (fills remaining space)
            Label lblDesc = new Label
            {
                Text = $"📝 {desc}",
                Font = new Font("Segoe UI Emoji", 12, FontStyle.Regular),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoEllipsis = true
            };

            // Add to layout
            layout.Controls.Add(lblProjectName, 0, 0);
            layout.Controls.Add(lblProjectId, 0, 1);
            layout.Controls.Add(datesPanel, 0, 2);
            layout.Controls.Add(lblDesc, 0, 3);

            // Center content inside card
            layout.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;

            card.Controls.Add(layout);
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Close current dashboard
                this.Hide();

                // Open Login form again
                Login loginForm = new Login();
                loginForm.Show();

                // Optionally dispose the current form
              
            }
        }

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