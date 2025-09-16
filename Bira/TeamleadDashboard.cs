using Bira.Models;
using Bira.Naveen;
using Bira.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bira
{
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

            // Define colors
            Color defaultBack = Color.Transparent;
            Color hoverBack = Color.FromArgb(45, 45, 48);   // hover gray
            Color activeBack = Color.FromArgb(28, 151, 234); // active blue

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
                        }

                        //foreach (var otherBtn in otherPn.Controls.OfType<Button>())
                        //{
                        //    otherBtn.Tag = "inactive";
                        //    otherBtn.BackColor = defaultBack;
                        //}
                    }

                    btn.Tag = "active";
                    btn.BackColor = activeBack;

                    onClick(item);
                };

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
            panelMain.Controls.Clear();  // Clear any existing controls in panelMain (or use panel2)

            EditProject EditprojectForm = new EditProject(projectId);

            EditprojectForm.TopLevel = false;     // Make the form a child control, not a top-level window
            EditprojectForm.FormBorderStyle = FormBorderStyle.None;
            EditprojectForm.Dock = DockStyle.Fill; // Fill the panel fully


            panelMain.Controls.Add(EditprojectForm);  // Add to panel2 (or panelMain, depending on your design)
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
                // Call the service to delete the project data
                // await _projectService.DeleteProjectAsync(projectId);

                // Inform the user of success
                MessageBox.Show("Project has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the UI to reflect the changes
                panelMain.Controls.Clear(); // Clear the main view
                LoadAllData(); // Reload the sidebar menus
            }
        }

        private void EditTeam(int teamId)
        {
            panelMain.Controls.Clear();  // Clear any existing controls in panelMain (or use panel2)

            EditTeam EditTeamForm = new EditTeam(teamId);

            EditTeamForm.TopLevel = false;     // Make the form a child control, not a top-level window
            EditTeamForm.FormBorderStyle = FormBorderStyle.None;
            EditTeamForm.Dock = DockStyle.Fill; // Fill the panel fully


            panelMain.Controls.Add(EditTeamForm);  // Add to panel2 (or panelMain, depending on your design)
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
                // Call the service to delete the project data
                // await _projectService.DeleteProjectAsync(projectId);

                // Inform the user of success
                MessageBox.Show("Team has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the UI to reflect the changes
                panelMain.Controls.Clear(); // Clear the main view
                LoadAllData(); // Reload the sidebar menus
            }
        }

        private void EditTask(int taskId)
        {
            panelMain.Controls.Clear();  // Clear any existing controls in panelMain (or use panel2)

            EditTask EditTaskForm = new EditTask(taskId)
            {
                TopLevel = false,         // Make the form a child control, not a top-level window
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill     // Fill the panel fully
            };

            panelMain.Controls.Add(EditTaskForm);  // Add to panel2 (or panelMain, depending on your design)
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
                // Call the service to delete the project data
                // await _projectService.DeleteProjectAsync(projectId);

                // Inform the user of success
                MessageBox.Show("Task has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the UI to reflect the changes
                panelMain.Controls.Clear(); // Clear the main view
                LoadAllData(); // Reload the sidebar menus
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
        private static readonly Random _rnd = new Random();
        private Color GetRandomColor()
        {
            return Color.FromArgb(_rnd.Next(100, 256), _rnd.Next(100, 256), _rnd.Next(100, 256));
        }
        private Panel CreateAvatar(string name, Color bgColor)
        {
            Panel avatar = new Panel
            {
                Width = 60,
                Height = 60,
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

        #region Display All Backlogs (Grid View)

        /// <summary>
        /// Fetches all backlog items and displays them as a grid of cards in the main panel.
        /// This replaces the previous "Show More" button functionality.
        /// </summary>
        /// 
        // Helper function to assign colors based on priority
        private Color GetPriorityColor(string priority)
        {

            switch (priority?.ToLower())
            {
                case "high":
                    return Color.FromArgb(255, 128, 128); // Light Red
                case "medium":
                    return Color.FromArgb(255, 192, 128); // Light Orange
                case "low":
                    return Color.FromArgb(144, 238, 144); // Light Green
                default:
                    return Color.LightGray;
            }
        }

        private async void DisplayAllBacklogCards()
        {
            // Get all backlog items (assuming this method now exists in the service)
            var backlogItems = await _backlogService.GetBacklogItemsAsync();

            // MODIFIED: Target panel is now panelMain
            panelMain.Controls.Clear();

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                Padding = new Padding(20) // MODIFIED: Increased padding
            };

            foreach (var item in backlogItems)
            {
                Panel card = new Panel
                {
                    Width = 350, // MODIFIED: Increased width for more content
                    Height = 300, // MODIFIED: Increased height for the description
                    BackColor = Color.FromArgb(45, 65, 90), // Enhanced color
                    Margin = new Padding(15),
                    Padding = new Padding(20),
                    Cursor = Cursors.Hand,
                    Tag = item
                };

                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20));

                // --- ENHANCED LAYOUT ---

                // 1. Header Panel for Title
                Label lblName = new Label
                {
                    Text = item.Title,
                    // MODIFIED: Larger, bolder font for the title
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                    ForeColor = Color.White,
                    Dock = DockStyle.Top,
                    Height = 50, // MODIFIED: Increased height
                    AutoEllipsis = true
                };

                // 2. Description Label (takes up the middle space)
                Label lblDesc = new Label
                {
                    Text = item.Description,
                    // MODIFIED: Larger italic font for description
                    Font = new Font("Segoe UI", 11F, FontStyle.Italic),
                    ForeColor = Color.LightGray,
                    Dock = DockStyle.Fill, // Fills the remaining space
                    Padding = new Padding(0, 5, 0, 5)
                };

                // 3. Footer Panel for Status and Priority
                Panel footerPanel = new Panel { Dock = DockStyle.Bottom, Height = 30 }; // MODIFIED: Increased height

                Label lblStatus = new Label
                {
                    Text = $"Status: {item.Status}",
                    // MODIFIED: Larger font
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = Color.LightCyan,
                    Dock = DockStyle.Left,
                    AutoSize = true
                };

                Label lblPriority = new Label
                {
                    Text = $"Priority: {item.Priority}",
                    // MODIFIED: Larger font
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = GetPriorityColor(item.Priority),
                    Dock = DockStyle.Right,
                    AutoSize = true
                };

                footerPanel.Controls.Add(lblStatus);
                footerPanel.Controls.Add(lblPriority);

                // Add controls in reverse order of docking (Fill, Bottom, Top)
                card.Controls.Add(lblDesc);
                card.Controls.Add(footerPanel);
                card.Controls.Add(lblName);

                // Make the entire card clickable
                card.Click += (s, ev) => Card_ClickHandler(card);
                foreach (Control ctrl in card.Controls)
                {
                    // Make child controls also trigger the main card click
                    ctrl.Click += (s, ev) => Card_ClickHandler(card);
                    if (ctrl is Panel p) // Also handle clicks on panels within the card
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

        private void OpenBacklog(int itemId, string title, string description, string status, string priority)
        {
            // CORRECTED: This now calls the correct method 'DisplayBacklogItemCard' to show a single item's details.
            DisplayBacklogCard(itemId, title, description, status, priority, Color.FromArgb(91, 147, 189));
        }


        private void DisplayBacklogCard(int itemId, string title, string description, string status, string priority, Color color)
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
            };

            card.Region = Region.FromHrgn(
                WinApi.CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20)
            );

            Label lblTitle = new Label
            {
                Text = $"📝 {title} (ID: {itemId})",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                Height = 40
            };

            Label lblStatusLabel = new Label
            {
                Text = $"Status: {status}",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                Height = 30
            };

            Label lblPriorityLabel = new Label
            {
                Text = $"Priority: {priority}",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                Height = 30
            };

            Label lblDesc = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                ForeColor = Color.White,
                Dock = DockStyle.Fill
            };

            card.Controls.Add(lblDesc);
            card.Controls.Add(lblPriorityLabel);
            card.Controls.Add(lblStatusLabel);
            card.Controls.Add(lblTitle);

            panelMain.Controls.Add(card);
        }

        #endregion

        #region Detailed View Display Methods (New)

        /// <summary>
        /// Displays a detailed card showing the entire backlog for a specific project.
        /// </summary>
        private void DisplayProjectBacklogCard(int projectId, string projectName, List<BacklogModel> backlogItems, Color color)
        {
            panelMain.Controls.Clear();

            Panel card = new Panel
            {
                Dock = DockStyle.Fill,
                Width = panelMain.Width - 25,
                Height = 450, // Increased height to accommodate more content
                BackColor = color,
                Padding = new Padding(15),
                Margin = new Padding(10),
                BorderStyle = BorderStyle.None,
                AutoScroll = true
            };

            // Apply rounded corners
            card.Region = Region.FromHrgn(
                WinApi.CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20)
            );

            Label lblBacklogTitle = new Label
            {
                Text = $"📋 Backlog: {projectName} (ID: {projectId})",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                Height = 40
            };

            // Handle case where there are no backlog items FIRST
            if (backlogItems.Count == 0)
            {
                Label lblNoItems = new Label
                {
                    Text = "No backlog items found for this project.",
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = Color.LightGray,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    AutoSize = true
                };

                card.Controls.Add(lblNoItems);
                card.Controls.Add(lblBacklogTitle);
                panelMain.Controls.Add(card);
                return; // Exit the method early since there's nothing else to do
            }


            FlowLayoutPanel itemsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                FlowDirection = FlowDirection.TopDown,
                BackColor = Color.FromArgb(50, color)
            };

            foreach (var item in backlogItems)
            {
                Panel itemCard = new Panel
                {
                    Width = 800, // Slightly narrower for better padding
                    Height = 140, // Increased height to fit description
                    BackColor = Color.FromArgb(80, color),
                    Margin = new Padding(5),
                    Padding = new Padding(10)
                };

                itemCard.Region = Region.FromHrgn(
                    WinApi.CreateRoundRectRgn(0, 0, itemCard.Width, itemCard.Height, 15, 15)
                );

                // Title Label
                Label lblItemTitle = new Label
                {
                    Text = $"📝 {item.Title}",
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.White,
                    Dock = DockStyle.Top,
                    Height = 30,
                    Width = itemCard.Width - 20,
                };

                // Description Label - THIS IS WHAT WAS MISSING
                Label lblItemDescription = new Label
                {
                    Text = item.Description,
                    Font = new Font("Segoe UI", 9, FontStyle.Italic),
                    ForeColor = Color.LightGray,
                    Dock = DockStyle.Top,
                    Height = 45, // Fixed height for description
                    AutoEllipsis = true, // Add "..." if text overflows
                    Padding = new Padding(0, 5, 0, 5) // Add some vertical padding
                };


                Label lblItemStatus = new Label
                {
                    Dock = DockStyle.Bottom,
                    Text = $"📊 Status: {item.Status}",
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    ForeColor = Color.White,
                    AutoSize = true,
                    Margin = new Padding(0, 0, 15, 0) // Add right margin
                };

                Label lblItemPriority = new Label
                {
                    Dock = DockStyle.Bottom,
                    Text = $"🔺 Priority: {item.Priority}",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = GetPriorityColor(item.Priority), // Use your existing priority color method
                    AutoSize = true
                };

                // Add status and priority to footer panel
                
                itemCard.Controls.Add(lblItemDescription);
                itemCard.Controls.Add(lblItemTitle);
                itemCard.Controls.Add(lblItemStatus);
                itemCard.Controls.Add(lblItemPriority);

                itemsPanel.Controls.Add(itemCard);
            }

            card.Controls.Add(itemsPanel);
            card.Controls.Add(lblBacklogTitle);

            panelMain.Controls.Add(card);
        }
        #endregion



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

            // 1. Create a "View Backlog" Button
            Button btnViewBacklog = new Button
            {
                Text = "📋 View Project Backlog",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(0, 98, 152), // A nice blue
                FlatStyle = FlatStyle.Flat,
                Height = 35,
                Dock = DockStyle.Bottom,
                Margin = new Padding(0, 10, 0, 0),
                Cursor = Cursors.Hand
            };
            btnViewBacklog.FlatAppearance.BorderSize = 0;

            // 2. Handle the button click
            btnViewBacklog.Click += async (sender, e) =>
            {
                // Fetch the backlog items for THIS specific project
                var allBacklogItems = await _backlogService.GetBacklogItemsAsync();
                var projectBacklogItems = allBacklogItems.Where(b => b.ProjectId == projectId).ToList();

                // Call the method to display them
                DisplayProjectBacklogCard(projectId, projectName, projectBacklogItems, color);
            };

            // Add in order
            card.Controls.Add(txtDesc);
            card.Controls.Add(btnViewBacklog);
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



        private void buttonProjectsAdd_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();  // Clear any existing controls in panelMain (or use panel2)

            ProjectForm projectForm = new ProjectForm
            {
                TopLevel = false,         // Make the form a child control, not a top-level window
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill     // Fill the panel fully
            };

            panelMain.Controls.Add(projectForm);  // Add to panel2 (or panelMain, depending on your design)
            projectForm.Show();
        }

        private void buttonForyou_Click(object sender, EventArgs e)
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
                // Close current dashboard
                this.Hide();

                // Open Login form again
                Login loginForm = new Login();
                loginForm.Show();

                // Optionally dispose the current form
                this.Close();
            }
        }

        private void buttonBacklogs_Click(object sender, EventArgs e)
        {
            DisplayAllBacklogCards();
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
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
  
}
