using Bira.Models;
using Bira.Naveen;
using Bira.Services;
using Bira.UI;
using Bira.UiHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bira
{
    using System.Drawing.Drawing2D;
    using System.Media;
    using System.Runtime.InteropServices;

    public partial class TeamleadDashboard : Form
    {
        private readonly ProjectService _projectService = new ProjectService();
        private readonly TeamService _teamService = new TeamService();
        private readonly TaskService _taskService = new TaskService();
        private readonly BacklogService _backlogService = new BacklogService();

        private ContextMenuStrip _contextMenu;
        private int _currentItemId;
        private string _currentItemType;

        private void InitializeContextMenu()
        {
            _contextMenu = new ContextMenuStrip
            {
                BackColor = Color.FromArgb(31, 41, 55),
                ForeColor = Color.FromArgb(249, 250, 251)
            };

            var editItem = new ToolStripMenuItem("✏️ Edit")
            {
                ForeColor = Color.FromArgb(249, 250, 251)
            };
            editItem.Click += (s, e) => HandleEdit();

            var deleteItem = new ToolStripMenuItem("🗑️ Delete")
            {
                ForeColor = Color.FromArgb(220, 53, 69)
            };
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
            LoadForyouDashboard();
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
        private async Task PopulateSubMenu<T>(Panel panel, Button showMoreBtn, List<T> items, List<string> names, Action<T> onClick)
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

            // Define cool colors
            Color defaultBack = Color.Transparent;
            Color hoverBack = Color.FromArgb(59, 130, 246);   // Cool blue hover
            Color activeBack = Color.FromArgb(37, 99, 235);   // Deeper blue accent

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
                    ForeColor = Color.FromArgb(156, 163, 175),
                    Text = names[i],
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(35, 0, 0, 0),
                    Height = 40,
                    Dock = DockStyle.Fill,
                    BackColor = defaultBack,
                    Tag = "inactive"
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

                // Active click
                btn.Click += (s, e) =>
                {
                    foreach (var otherPn in panel.Controls.OfType<Panel>().Where(p => p.Tag?.ToString() == "DynamicItem"))
                    {
                        foreach (var otherBtn in otherPn.Controls.OfType<Button>().Where(b => b.Dock == DockStyle.Fill))
                        {
                            otherBtn.Tag = "inactive";
                            otherBtn.BackColor = defaultBack;
                            otherBtn.ForeColor = Color.FromArgb(156, 163, 175);
                        }
                    }

                    btn.Tag = "active";
                    btn.BackColor = activeBack;
                    btn.ForeColor = Color.White;

                    onClick(item);
                };

                // 3-dot button
                Button btn2 = new Button
                {
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(107, 114, 128),
                    Text = "⋮", // vertical ellipsis
                    Width = 40,
                    Dock = DockStyle.Right,
                    Tag = new Tuple<int, string>(itemId, itemType)
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

        private void EditProject(int projectId)
        {
            panelMain.Controls.Clear();

            EditProject EditprojectForm = new EditProject(projectId);

            EditprojectForm.TopLevel = false;
            EditprojectForm.FormBorderStyle = FormBorderStyle.None;
            EditprojectForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(EditprojectForm);
            EditprojectForm.Show();
        }

        private void DeleteProject(int projectId)
        {
            SystemSounds.Hand.Play();
            DialogResult result = MessageBox.Show(
               "Are you sure you want to Delete This Project Permanently?",
               "Delete Project",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Project has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelMain.Controls.Clear();
                LoadAllData();
            }
        }

        private void EditTeam(int teamId)
        {
            panelMain.Controls.Clear();

            EditTeam EditTeamForm = new EditTeam(teamId);

            EditTeamForm.TopLevel = false;
            EditTeamForm.FormBorderStyle = FormBorderStyle.None;
            EditTeamForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(EditTeamForm);
            EditTeamForm.Show();
        }

        private void DeleteTeam(int teamId)
        {
            SystemSounds.Hand.Play();
            DialogResult result = MessageBox.Show(
               "Are you sure you want to Delete This Team Permanently?",
               "Delete Team",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Team has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelMain.Controls.Clear();
                LoadAllData();
            }
        }

        private void EditTask(int taskId)
        {
            panelMain.Controls.Clear();

            EditTask EditTaskForm = new EditTask(taskId)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelMain.Controls.Add(EditTaskForm);
            EditTaskForm.Show();
        }

        private void DeleteTask(int taskId)
        {
            SystemSounds.Hand.Play();
            DialogResult result = MessageBox.Show(
               "Are you sure you want to Delete This Task Permanently?",
               "Delete Task",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Task has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelMain.Controls.Clear();
                LoadAllData();
            }
        }

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

        #region Display All Backlogs (Grid View)

        // Helper function to assign colors based on priority
        private Color GetPriorityColor(string priority)
        {
            switch (priority?.ToLower())
            {
                case "high":
                    return Color.FromArgb(239, 68, 68); // Red-500
                case "medium":
                    return Color.FromArgb(251, 146, 60); // Orange-400
                case "low":
                    return Color.FromArgb(34, 197, 94); // Green-500
                default:
                    return Color.FromArgb(107, 114, 128); // Gray-500
            }
        }

        private async void DisplayAllBacklogCards()
        {
            var backlogItems = await _backlogService.GetBacklogItemsAsync();

            panelMain.Controls.Clear();

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                Padding = new Padding(20),
                BackColor = Color.White
            };

            foreach (var item in backlogItems)
            {
                Panel card = new Panel
                {
                    Width = 350,
                    Height = 300,
                    BackColor = Color.FromArgb(248, 250, 252),
                    Margin = new Padding(15),
                    Padding = new Padding(20),
                    Cursor = Cursors.Hand,
                    Tag = item
                };

                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20));

                // Add subtle shadow effect with border
                card.Paint += (s, e) =>
                {
                    using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 2))
                    {
                        e.Graphics.DrawCustomRoundedRectangle(borderPen, new Rectangle(1, 1, card.Width - 3, card.Height - 3), 18);
                    }
                };

                // Header Panel for Title
                Label lblName = new Label
                {
                    Text = item.Title,
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 41, 59),
                    Dock = DockStyle.Top,
                    Height = 50,
                    AutoEllipsis = true
                };

                // Description Label
                Label lblDesc = new Label
                {
                    Text = item.Description,
                    Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Dock = DockStyle.Fill,
                    Padding = new Padding(0, 5, 0, 5)
                };

                // Footer Panel for Status and Priority
                Panel footerPanel = new Panel { Dock = DockStyle.Bottom, Height = 30 };

                Label lblStatus = new Label
                {
                    Text = $"Status: {item.Status}",
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(59, 130, 246),
                    Dock = DockStyle.Left,
                    AutoSize = true
                };

                Label lblPriority = new Label
                {
                    Text = $"Priority: {item.Priority}",
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = GetPriorityColor(item.Priority),
                    Dock = DockStyle.Right,
                    AutoSize = true
                };

                footerPanel.Controls.Add(lblStatus);
                footerPanel.Controls.Add(lblPriority);

                card.Controls.Add(lblDesc);
                card.Controls.Add(footerPanel);
                card.Controls.Add(lblName);

                // Make the entire card clickable
                card.Click += (s, ev) => Card_ClickHandler(card);
                foreach (Control ctrl in card.Controls)
                {
                    ctrl.Click += (s, ev) => Card_ClickHandler(card);
                    if (ctrl is Panel p)
                    {
                        foreach (Control innerCtrl in p.Controls)
                        {
                            innerCtrl.Click += (s, ev) => Card_ClickHandler(card);
                        }
                    }
                }

                flow.Controls.Add(card);
            }

            panelMain.Controls.Add(flow);
        }
        #endregion

        private void Card_ClickHandler(Panel card)
        {
            if (card.Tag is ProjectModel p)
                OpenProject(p.ProjectId, p.Name, p.Description, p.StartDate, p.EndDate);
            else if (card.Tag is TeamModel t)
                OpenTeam(t.TeamId, t.Name, t.Members);
            else if (card.Tag is TaskModel task)
                OpenTask(task.TaskId, task.Name, task.ProjectName, task.Description, task.startDate, task.endDate, task.Priority, task.Status);
            else if (card.Tag is BacklogModel item)
                OpenBacklog(item.ItemId, item.Title, item.Description, item.Status, item.Priority);
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
                WrapContents = true,
                Padding = new Padding(20),
                BackColor = Color.White
            };

            foreach (var project in projects)
            {
                Panel card = new Panel
                {
                    Width = 350,
                    Height = 300,
                    BackColor = Color.FromArgb(248, 250, 252),
                    Margin = new Padding(15),
                    Padding = new Padding(20),
                    Cursor = Cursors.Hand,
                    Tag = project
                };

                card.Region = Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20)
                );

                // Add border
                card.Paint += (s, e) =>
                {
                    using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 2))
                    {
                        e.Graphics.DrawCustomRoundedRectangle(borderPen, new Rectangle(1, 1, card.Width - 3, card.Height - 3), 18);
                    }
                };

                // Project Name
                Label lblName = new Label
                {
                    Text = project.Name,
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 41, 59),
                    Dock = DockStyle.Top,
                    Height = 50,
                    AutoEllipsis = true
                };

                // Dates
                Label lblDates = new Label
                {
                    Text = $"{project.StartDate:dd MMM yyyy} ➝ {project.EndDate:dd MMM yyyy}",
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Dock = DockStyle.Top,
                    Height = 25,
                    AutoEllipsis = true
                };

                // Description
                Label lblDesc = new Label
                {
                    Text = project.Description,
                    Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Dock = DockStyle.Fill,
                    Padding = new Padding(0, 5, 0, 5),
                    AutoEllipsis = true
                };

                // Footer
                Panel footerPanel = new Panel
                {
                    Dock = DockStyle.Bottom,
                    Height = 30
                };

                Label lblId = new Label
                {
                    Text = $"ID: {project.ProjectId}",
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(59, 130, 246),
                    Dock = DockStyle.Left,
                    AutoSize = true
                };

                footerPanel.Controls.Add(lblId);

                card.Controls.Add(lblDesc);
                card.Controls.Add(footerPanel);
                card.Controls.Add(lblDates);
                card.Controls.Add(lblName);

                // Make the entire card clickable
                card.Click += (s, ev) =>
                {
                    var p = (ProjectModel)card.Tag;
                    OpenProject(p.ProjectId, p.Name, p.Description, p.StartDate, p.EndDate);
                };

                foreach (Control ctrl in card.Controls)
                {
                    ctrl.Click += (s, ev) => Card_ClickHandler(card);
                    if (ctrl is Panel p)
                    {
                        foreach (Control inner in p.Controls)
                        {
                            inner.Click += (s, ev) => Card_ClickHandler(card);
                        }
                    }
                }

                flow.Controls.Add(card);
            }

            panelMain.Controls.Add(flow);
        }

        private async void buttonTeamsShowMore_Click(object sender, EventArgs e)
        {
            var teams = await _teamService.GetTeamsAsync();

            panelMain.Controls.Clear();

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                Padding = new Padding(20),
                BackColor = Color.White
            };

            foreach (var team in teams)
            {
                Panel card = new Panel
                {
                    Width = 350,
                    Height = 300,
                    BackColor = Color.FromArgb(248, 250, 252),
                    Margin = new Padding(15),
                    Padding = new Padding(20),
                    Cursor = Cursors.Hand,
                    Tag = team
                };

                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20));

                // Add border
                card.Paint += (s, e) =>
                {
                    using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 2))
                    {
                        e.Graphics.DrawCustomRoundedRectangle(borderPen, new Rectangle(1, 1, card.Width - 3, card.Height - 3), 18);
                    }
                };

                // Header
                Label lblName = new Label
                {
                    Text = team.Name,
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 41, 59),
                    Dock = DockStyle.Top,
                    Height = 50,
                    AutoEllipsis = true
                };

                // Description (Members list)
                Label lblMembers = new Label
                {
                    Text = $"Members: {team.Members.Count}",
                    Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Dock = DockStyle.Fill,
                    Padding = new Padding(0, 5, 0, 5)
                };

                // Footer
                Panel footerPanel = new Panel { Dock = DockStyle.Bottom, Height = 30 };

                Label lblId = new Label
                {
                    Text = $"Team ID: {team.TeamId}",
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(59, 130, 246),
                    Dock = DockStyle.Left,
                    AutoSize = true
                };

                footerPanel.Controls.Add(lblId);

                // Add to card
                card.Controls.Add(lblMembers);
                card.Controls.Add(footerPanel);
                card.Controls.Add(lblName);

                // Click event
                card.Click += (s, ev) => OpenTeam(team.TeamId, team.Name, team.Members);
                foreach (Control ctrl in card.Controls)
                {
                    ctrl.Click += (s, ev) => Card_ClickHandler(card);
                    if (ctrl is Panel p)
                        foreach (Control inner in p.Controls)
                            inner.Click += (s, ev) => Card_ClickHandler(card);
                }

                flow.Controls.Add(card);
            }

            panelMain.Controls.Add(flow);
        }

        private async void buttonTasksShowMore_Click(object sender, EventArgs e)
        {
            var tasks = await _taskService.GetTasksAsync();

            panelMain.Controls.Clear();

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                Padding = new Padding(20),
                BackColor = Color.White
            };

            foreach (var task in tasks)
            {
                Panel card = new Panel
                {
                    Width = 350,
                    Height = 300,
                    BackColor = Color.FromArgb(248, 250, 252),
                    Margin = new Padding(15),
                    Padding = new Padding(20),
                    Cursor = Cursors.Hand,
                    Tag = task
                };

                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20));

                // Add border
                card.Paint += (s, e) =>
                {
                    using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 2))
                    {
                        e.Graphics.DrawCustomRoundedRectangle(borderPen, new Rectangle(1, 1, card.Width - 3, card.Height - 3), 18);
                    }
                };

                // Header
                Label lblName = new Label
                {
                    Text = task.Name,
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 41, 59),
                    Dock = DockStyle.Top,
                    Height = 50,
                    AutoEllipsis = true
                };

                // Project
                Label lblProject = new Label
                {
                    Text = $"📂 {task.ProjectName}",
                    Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Dock = DockStyle.Top,
                    Height = 25,
                    AutoEllipsis = true
                };

                Label lblDesc = new Label
                {
                    Text = task.Description,
                    Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Dock = DockStyle.Fill,
                    Padding = new Padding(0, 5, 0, 5),
                    AutoEllipsis = true
                };

                // Footer (Status + Priority)
                Panel footerPanel = new Panel { Dock = DockStyle.Bottom, Height = 30 };

                Label lblStatus = new Label
                {
                    Text = $"Status: {task.Status}",
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = Color.FromArgb(59, 130, 246),
                    Dock = DockStyle.Left,
                    AutoSize = true
                };

                Label lblPriority = new Label
                {
                    Text = $"Priority: {task.Priority}",
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = GetPriorityColor(task.Priority),
                    Dock = DockStyle.Right,
                    AutoSize = true
                };

                footerPanel.Controls.Add(lblStatus);
                footerPanel.Controls.Add(lblPriority);

                // Add to card
                card.Controls.Add(lblDesc);
                card.Controls.Add(footerPanel);
                card.Controls.Add(lblProject);
                card.Controls.Add(lblName);

                // Click event
                card.Click += (s, ev) => OpenTask(task.TaskId, task.Name, task.ProjectName, task.Description, task.startDate, task.endDate, task.Priority, task.Status);
                foreach (Control ctrl in card.Controls)
                {
                    ctrl.Click += (s, ev) => Card_ClickHandler(card);
                    if (ctrl is Panel p)
                        foreach (Control inner in p.Controls)
                            inner.Click += (s, ev) => Card_ClickHandler(card);
                }

                flow.Controls.Add(card);
            }

            panelMain.Controls.Add(flow);
        }

        #endregion

        #region Item Click Handlers
        private void OpenProject(int projectId, string projectName, string desc, DateTime startDate, DateTime endDate)
        {
            DisplayProjectCard(projectId, projectName, startDate, endDate, desc, Color.FromArgb(37, 99, 235));
        }

        private void OpenTeam(int teamId, string teamName, List<MemberModel> members)
        {
            DisplayTeamCard(teamId, teamName, members, Color.FromArgb(16, 185, 129));
        }

        private void OpenTask(int taskId, string taskName, string projectName, string desc, DateTime startDate, DateTime endDate, string priority, string status)
        {
            DisplayTaskCard(taskId, taskName, projectName, desc, startDate, endDate, priority, status, Color.FromArgb(139, 92, 246));
        }

        private void OpenBacklog(int itemId, string title, string description, string status, string priority)
        {
            DisplayBacklogCard(itemId, title, description, status, priority, Color.FromArgb(59, 130, 246));
        }

        private void DisplayBacklogCard(int itemId, string title, string description, string status, string priority, Color color)
        {
            panelMain.Controls.Clear();

            Panel card = new Panel
            {
                Width = panelMain.Width - 20,
                Height = 300,
                BackColor = Color.FromArgb(248, 250, 252),
                Padding = new Padding(15),
                Margin = new Padding(10),
                BorderStyle = BorderStyle.None,
            };

            card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20));

            // Add border
            card.Paint += (s, e) =>
            {
                using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 2))
                {
                    e.Graphics.DrawCustomRoundedRectangle(borderPen, new Rectangle(1, 1, card.Width - 3, card.Height - 3), 18);
                }
            };

            Label lblTitle = new Label
            {
                Text = $"📝 {title} (ID: {itemId})",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Dock = DockStyle.Top,
                Height = 40
            };

            Label lblStatusLabel = new Label
            {
                Text = $"Status: {status}",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(59, 130, 246),
                Dock = DockStyle.Top,
                Height = 30
            };

            Label lblPriorityLabel = new Label
            {
                Text = $"Priority: {priority}",
                Font = new Font("Segoe UI", 11),
                ForeColor = GetPriorityColor(priority),
                Dock = DockStyle.Top,
                Height = 30
            };

            Label lblDesc = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(71, 85, 105),
                Dock = DockStyle.Fill
            };

            card.Controls.Add(lblDesc);
            card.Controls.Add(lblPriorityLabel);
            card.Controls.Add(lblStatusLabel);
            card.Controls.Add(lblTitle);

            panelMain.Controls.Add(card);
        }

        #endregion

        #region Detailed View Display Methods

        private void DisplayProjectBacklogCard(int projectId, string projectName, List<BacklogModel> backlogItems, Color baseColor)
        {
            panelMain.Controls.Clear();

            Panel card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(20),
                BorderStyle = BorderStyle.None
            };

            card.Resize += (s, e) =>
            {
                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20));
            };

            Label lblBacklogTitle = new Label
            {
                Text = $"📋 Backlog: {projectName}",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.FromArgb(37, 99, 235),
                Dock = DockStyle.Top,
                Height = 60,
                TextAlign = ContentAlignment.MiddleCenter
            };

            if (backlogItems.Count == 0)
            {
                Label lblNoItems = new Label
                {
                    Text = "No backlog items found for this project.",
                    Font = new Font("Segoe UI", 14, FontStyle.Regular),
                    ForeColor = Color.FromArgb(107, 114, 128),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                card.Controls.Add(lblNoItems);
                card.Controls.Add(lblBacklogTitle);
                panelMain.Controls.Add(card);
                return;
            }

            FlowLayoutPanel itemsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.Transparent,
                Padding = new Padding(15)
            };

            foreach (var item in backlogItems)
            {
                Panel itemCard = new Panel
                {
                    Height = 150,
                    BackColor = Color.FromArgb(248, 250, 252),
                    Margin = new Padding(10),
                    Padding = new Padding(15)
                };

                // Add border to item card
                itemCard.Paint += (s, e) =>
                {
                    using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 1))
                    {
                        e.Graphics.DrawRoundedRectangle(borderPen, new Rectangle(0, 0, itemCard.Width - 1, itemCard.Height - 1), 15);
                    }
                };

                Label lblItemTitle = new Label
                {
                    Text = $"📝 {item.Title}",
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 41, 59),
                    Dock = DockStyle.Top,
                    Height = 35,
                    AutoEllipsis = true
                };

                Label lblItemDescription = new Label
                {
                    Text = item.Description,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Dock = DockStyle.Fill,
                    Padding = new Padding(0, 5, 0, 5)
                };

                Panel footerPanel = new Panel
                {
                    Dock = DockStyle.Bottom,
                    Height = 25,
                    BackColor = Color.Transparent
                };

                Label lblItemStatus = new Label
                {
                    Text = $"📊 Status: {item.Status}",
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.FromArgb(59, 130, 246),
                    Dock = DockStyle.Left,
                    AutoSize = true
                };

                Label lblItemPriority = new Label
                {
                    Text = $"🔺 Priority: {item.Priority}",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = GetPriorityColor(item.Priority),
                    Dock = DockStyle.Right,
                    AutoSize = true
                };

                footerPanel.Controls.Add(lblItemStatus);
                footerPanel.Controls.Add(lblItemPriority);

                // Add controls to item card in correct order (bottom to top for docking)
                itemCard.Controls.Add(lblItemDescription);  // Fill - added first
                itemCard.Controls.Add(footerPanel);         // Bottom
                itemCard.Controls.Add(lblItemTitle);        // Top

                itemsPanel.Controls.Add(itemCard);
            }

            // Handle layout updates to ensure proper sizing
            itemsPanel.Layout += (s, e) =>
            {
                var panel = s as FlowLayoutPanel;
                if (panel != null)
                {
                    foreach (Panel childCard in panel.Controls.OfType<Panel>())
                    {
                        childCard.Width = panel.ClientSize.Width - 40;
                        childCard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, childCard.Width, childCard.Height, 15, 15));
                    }
                }
            };

            // Add controls to main card in correct order (bottom to top for docking)
            card.Controls.Add(itemsPanel);      // Fill - added first
            card.Controls.Add(lblBacklogTitle); // Top - added last

            panelMain.Controls.Add(card);
        }
        private void itemsPanel_Resize(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            if (panel != null)
            {
                foreach (Panel childCard in panel.Controls.OfType<Panel>())
                {
                    childCard.Width = panel.ClientSize.Width - 40;
                }
            }
        }
        #endregion

        private void DisplayTeamCard(int teamId, string teamName, List<MemberModel> teamMembers, Color baseColor)
        {
            panelMain.Controls.Clear();

            Panel card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(20),
                BorderStyle = BorderStyle.None,
                AutoScroll = true
            };

            card.Resize += (s, e) =>
            {
                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20));
            };

            Label lblTeamTitle = new Label
            {
                Text = $"👥 Team: {teamName} (ID: {teamId})",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Dock = DockStyle.Top,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter
            };

            FlowLayoutPanel membersPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                Padding = new Padding(10),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            foreach (var member in teamMembers)
            {
                Panel memberCard = new Panel
                {
                    Width = 250,
                    Height = 100,
                    BackColor = Color.White,
                    Margin = new Padding(10),
                    Padding = new Padding(10),
                    Cursor = Cursors.Hand
                };

                memberCard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, memberCard.Width, memberCard.Height, 15, 15));

                // Add border to member card
                memberCard.Paint += (s, e) =>
                {
                    using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 2))
                    {
                        e.Graphics.DrawCustomRoundedRectangle(borderPen, new Rectangle(1, 1, memberCard.Width - 3, memberCard.Height - 3), 13);
                    }
                };

                Label lblMemberName = new Label
                {
                    Text = $"👤 {member.Name}",
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    ForeColor = Color.FromArgb(37, 99, 235),
                    Dock = DockStyle.Top,
                    Height = 30,
                    AutoEllipsis = true
                };

                Label lblMemberRole = new Label
                {
                    Text = $"🔧 {member.Role}",
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Dock = DockStyle.Fill,
                    AutoEllipsis = true
                };

                memberCard.Controls.Add(lblMemberRole);
                memberCard.Controls.Add(lblMemberName);

                memberCard.Click += (s, e) =>
                {
                    MessageBox.Show($"Open member profile: {member.Name}", "Member");
                };

                foreach (Control ctrl in memberCard.Controls)
                {
                    ctrl.Click += (s, e) =>
                    {
                        MessageBox.Show($"Open member profile: {member.Name}", "Member");
                    };
                }

                membersPanel.Controls.Add(memberCard);
            }

            card.Controls.Add(membersPanel);
            card.Controls.Add(lblTeamTitle);

            panelMain.Controls.Add(card);
        }

        private void DisplayProjectCard(int projectId, string projectName, DateTime startDate, DateTime endDate, string desc, Color baseColor)
        {
            panelMain.Controls.Clear();

            Panel card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(20),
                BorderStyle = BorderStyle.None
            };

            card.Resize += (s, e) =>
            {
                card.Region = Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20));
            };

            Label lblProjectName = new Label
            {
                Text = projectName,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.FromArgb(37, 99, 235),
                Dock = DockStyle.Top,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblProjectId = new Label
            {
                Text = $"Project ID: {projectId}",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.FromArgb(71, 85, 105),
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter
            };

            TableLayoutPanel datesPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 40,
                ColumnCount = 2,
                BackColor = Color.Transparent
            };
            datesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            datesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            Label lblStart = new Label
            {
                Text = $"🟢 Start: {startDate:dd MMM yyyy}",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(16, 185, 129),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblEnd = new Label
            {
                Text = $"🔴 End: {endDate:dd MMM yyyy}",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(239, 68, 68),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight
            };

            datesPanel.Controls.Add(lblStart, 0, 0);
            datesPanel.Controls.Add(lblEnd, 1, 0);

            TextBox txtDesc = new TextBox
            {
                Text = desc,
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.FromArgb(30, 41, 59),
                BackColor = Color.FromArgb(248, 250, 252),
                Multiline = true,
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill
            };

            Button btnViewBacklog = new Button
            {
                Text = "📋 View Project Backlog",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(37, 99, 235),
                FlatStyle = FlatStyle.Flat,
                Height = 45,
                Dock = DockStyle.Bottom,
                Cursor = Cursors.Hand
            };
            btnViewBacklog.FlatAppearance.BorderSize = 0;

            btnViewBacklog.MouseEnter += (s, e) =>
                btnViewBacklog.BackColor = Color.FromArgb(29, 78, 216);
            btnViewBacklog.MouseLeave += (s, e) =>
                btnViewBacklog.BackColor = Color.FromArgb(37, 99, 235);

            btnViewBacklog.Click += async (s, e) =>
            {
                var allBacklogItems = await _backlogService.GetBacklogItemsAsync();
                var projectBacklogItems = allBacklogItems.Where(b => b.ProjectId == projectId).ToList();
                DisplayProjectBacklogCard(projectId, projectName, projectBacklogItems, baseColor);
            };

            card.Controls.Add(txtDesc);
            card.Controls.Add(btnViewBacklog);
            card.Controls.Add(datesPanel);
            card.Controls.Add(lblProjectId);
            card.Controls.Add(lblProjectName);

            panelMain.Controls.Add(card);
        }

        private void DisplayTaskCard(int taskId, string taskName, string projectName, string desc, DateTime startDate, DateTime endDate, string priority, string status, Color baseColor)
        {
            panelMain.Controls.Clear();

            Panel card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(20),
                BorderStyle = BorderStyle.None,
                AutoScroll = true
            };

            card.Resize += (s, e) =>
            {
                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20));
            };

            Label lblTaskName = new Label
            {
                Text = $"📝 {taskName} (ID: {taskId})",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Dock = DockStyle.Top,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter
            };

            TableLayoutPanel infoPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 40,
                ColumnCount = 2,
                BackColor = Color.Transparent
            };
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            Label lblProject = new Label
            {
                Text = $"📂 Project: {projectName}",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.FromArgb(59, 130, 246),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblDates = new Label
            {
                Text = $"⏳ {startDate:dd MMM yyyy} ➝ {endDate:dd MMM yyyy}",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.FromArgb(71, 85, 105),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight
            };

            infoPanel.Controls.Add(lblProject, 0, 0);
            infoPanel.Controls.Add(lblDates, 1, 0);

            TextBox txtDesc = new TextBox
            {
                Text = desc,
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.FromArgb(30, 41, 59),
                BackColor = Color.FromArgb(248, 250, 252),
                Multiline = true,
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill
            };

            Panel footerPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 45
            };

            Label lblPriority = new Label
            {
                Text = $"⚡ Priority: {priority}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = GetPriorityColor(priority),
                Dock = DockStyle.Left,
                AutoSize = true
            };

            Label lblStatus = new Label
            {
                Text = $"✅ Status: {status}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(16, 185, 129),
                Dock = DockStyle.Right,
                AutoSize = true
            };

            footerPanel.Controls.Add(lblPriority);
            footerPanel.Controls.Add(lblStatus);

            card.Controls.Add(txtDesc);
            card.Controls.Add(footerPanel);
            card.Controls.Add(infoPanel);
            card.Controls.Add(lblTaskName);

            panelMain.Controls.Add(card);
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void buttonProjectsAdd_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            ProjectForm projectForm = new ProjectForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelMain.Controls.Add(projectForm);
            projectForm.Show();
        }

        private void buttonForyou_Click(object sender, EventArgs e)
        {
            LoadForyouDashboard();
        }

        private void LoadForyouDashboard()
        {
            panelMain.Controls.Clear();

            ForYouDashboard oForyouDashboard = new ForYouDashboard
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelMain.Controls.Add(oForyouDashboard);
            oForyouDashboard.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }

        private void buttonBacklogs_Click(object sender, EventArgs e)
        {
            DisplayAllBacklogCards();
        }

        private void buttonTasksAdd_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            TasksForm oTasksForm = new TasksForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelMain.Controls.Add(oTasksForm);
            oTasksForm.Show();
        }

        private void buttonTeamsAdd_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            NewTeam oTeamForm = new NewTeam
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelMain.Controls.Add(oTeamForm);
            oTeamForm.Show();
        }
    }

    // Extension method for drawing rounded rectangles
    public static class GraphicsExtensions
    {
        public static void DrawCustomRoundedRectangle(this Graphics graphics, Pen pen, Rectangle rect, int radius)
        {
            using (GraphicsPath path = GetRoundedPath(rect, radius))
            {
                graphics.DrawPath(pen, path);
            }
        }

        private static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            // Top left corner
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // Top right corner  
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            // Bottom right corner
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            // Bottom left corner
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}