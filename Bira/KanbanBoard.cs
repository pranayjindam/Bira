using Bira.Models;
using Bira.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using Bira.UI;
using Bira.UiHelper;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bira
{
    public partial class KanbanBoard : Form
    {
        private readonly TaskService _taskService = new TaskService();
        private readonly ProjectService _projectService = new ProjectService();
        private List<TaskModel> _allTasks;
        private int _selectedProjectId = -1; // -1 means all projects

        // Drag and drop fields
        private Panel _draggedTask;
        private Point _dragOffset;
        private string _sourceColumn;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        public KanbanBoard()
        {
            InitializeComponent();
            InitializeBoard();
            LoadData();
        }

        private async void InitializeBoard()
        {
            // Load project filter dropdown
            await LoadProjectFilter();

            // Style the columns
            StyleColumns();
        }

        private async Task LoadProjectFilter()
        {
            try
            {
                var projects = await _projectService.GetProjectsAsync();

                comboBoxProjectFilter.Items.Clear();
                comboBoxProjectFilter.Items.Add("All Projects");

                foreach (var project in projects)
                {
                    comboBoxProjectFilter.Items.Add($"{project.Name} (ID: {project.ProjectId})");
                }

                comboBoxProjectFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading projects: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleColumns()
        {
            var columns = new[] { panelToDo, panelInProgress, panelReview, panelDone };
            var colors = new[]
            {
                Color.FromArgb(239, 68, 68),   // Red for To Do
                Color.FromArgb(251, 146, 60),  // Orange for In Progress  
                Color.FromArgb(59, 130, 246),  // Blue for Review
                Color.FromArgb(34, 197, 94)    // Green for Done
            };

            for (int i = 0; i < columns.Length; i++)
            {
                StyleColumn(columns[i], colors[i]);
            }
        }

        private void StyleColumn(Panel column, Color accentColor)
        {
            column.BackColor = Color.FromArgb(248, 250, 252);
            column.Padding = new Padding(10);

            // Add header styling
            var header = column.Controls.OfType<Label>().FirstOrDefault();
            if (header != null)
            {
                header.BackColor = accentColor;
                header.ForeColor = Color.White;
                header.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                header.Height = 40;
                header.TextAlign = ContentAlignment.MiddleCenter;
                header.Dock = DockStyle.Top;
            }

            // Allow drop on columns
            column.AllowDrop = true;
            column.DragEnter += Column_DragEnter;
            column.DragDrop += Column_DragDrop;
            column.DragOver += Column_DragOver;
        }

        private async 
        Task
LoadData()
        {
            try
            {
                _allTasks = await _taskService.GetTasksAsync();
                RefreshBoard();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tasks: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshBoard()
        {
            // Clear existing task cards
            ClearTaskCards();

            // Filter tasks
            var filteredTasks = FilterTasks();

            // Group tasks by status
            var taskGroups = filteredTasks.GroupBy(t => GetKanbanStatus(t.Status)).ToList();

            foreach (var group in taskGroups)
            {
                var targetPanel = GetColumnPanel(group.Key);
                if (targetPanel != null)
                {
                    foreach (var task in group.OrderBy(t => t.Priority == "High" ? 1 : t.Priority == "Medium" ? 2 : 3))
                    {
                        var taskCard = CreateTaskCard(task);
                        var containerPanel = targetPanel.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                        if (containerPanel != null)
                        {
                            containerPanel.Controls.Add(taskCard);
                        }
                    }
                }
            }

            UpdateColumnCounts();
        }

        private List<TaskModel> FilterTasks()
        {
            if (_selectedProjectId == -1)
                return _allTasks;

            return _allTasks.Where(t => t.ProjectId == _selectedProjectId).ToList();
        }

        private string GetKanbanStatus(string taskStatus)
        {
            // Map your task statuses to Kanban columns
            switch (taskStatus?.ToLower())
            {
                case "todo":
                case "not started":
                case "pending":
                    return "To Do";
                case "in progress":
                case "working":
                case "active":
                    return "In Progress";
                case "review":
                case "testing":
                case "validation":
                    return "Review";
                case "done":
                case "completed":
                case "finished":
                    return "Done";
                default:
                    return "To Do";
            }
        }

        private Panel GetColumnPanel(string status)
        {
            switch (status)
            {
                case "To Do": return panelToDo;
                case "In Progress": return panelInProgress;
                case "Review": return panelReview;
                case "Done": return panelDone;
                default: return panelToDo;
            }
        }

        private Panel CreateTaskCard(TaskModel task)
        {
            var card = new Panel
            {
                Width = 280,
                Height = 120,
                BackColor = Color.White,
                Margin = new Padding(5),
                Padding = new Padding(10),
                Cursor = Cursors.Hand,
                Tag = task
            };

            // Add rounded corners
            card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 12, 12));

            // Add border
            card.Paint += (s, e) =>
            {
                using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawCustomRoundedRectangle(borderPen, new Rectangle(0, 0, card.Width - 1, card.Height - 1), 12);
                }
            };

            // Task title
            var lblTitle = new Label
            {
                Text = task.Name,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Dock = DockStyle.Top,
                Height = 30,
                AutoEllipsis = true
            };

            // Project name
            var lblProject = new Label
            {
                Text = $"📂 {task.ProjectName}",
                Font = new Font("Segoe UI", 8, FontStyle.Regular),
                ForeColor = Color.FromArgb(107, 114, 128),
                Dock = DockStyle.Top,
                Height = 20,
                AutoEllipsis = true
            };

            // Priority indicator
            var lblPriority = new Label
            {
                Text = $"🔸 {task.Priority}",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = GetPriorityColor(task.Priority),
                Dock = DockStyle.Bottom,
                Height = 20,
                AutoSize = false
            };

            // Description (truncated)
            var lblDescription = new Label
            {
                Text = task.Description?.Length > 60 ? task.Description.Substring(0, 60) + "..." : task.Description,
                Font = new Font("Segoe UI", 8, FontStyle.Regular),
                ForeColor = Color.FromArgb(71, 85, 105),
                Dock = DockStyle.Fill,
                AutoEllipsis = true
            };

            card.Controls.Add(lblDescription);
            card.Controls.Add(lblPriority);
            card.Controls.Add(lblProject);
            card.Controls.Add(lblTitle);

            // Add drag and drop functionality
            card.MouseDown += TaskCard_MouseDown;
            card.MouseMove += TaskCard_MouseMove;
            card.MouseUp += TaskCard_MouseUp;
            card.Click += TaskCard_Click;

            return card;
        }

        private Color GetPriorityColor(string priority)
        {
            switch (priority?.ToLower())
            {
                case "high":
                    return Color.FromArgb(239, 68, 68);
                case "medium":
                    return Color.FromArgb(251, 146, 60);
                case "low":
                    return Color.FromArgb(34, 197, 94);
                default:
                    return Color.FromArgb(107, 114, 128);
            }
        }

        private void ClearTaskCards()
        {
            var columns = new[] { panelToDo, panelInProgress, panelReview, panelDone };
            foreach (var column in columns)
            {
                var flowPanel = column.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                if (flowPanel != null)
                {
                    flowPanel.Controls.Clear();
                }
            }
        }

        private void UpdateColumnCounts()
        {
            var columns = new[]
            {
                (panelToDo, "To Do"),
                (panelInProgress, "In Progress"),
                (panelReview, "Review"),
                (panelDone, "Done")
            };

            foreach (var (panel, status) in columns)
            {
                var flowPanel = panel.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                var count = flowPanel?.Controls.Count ?? 0;

                var header = panel.Controls.OfType<Label>().FirstOrDefault();
                if (header != null)
                {
                    header.Text = $"{status} ({count})";
                }
            }
        }

        #region Drag and Drop Implementation

        private void TaskCard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _draggedTask = sender as Panel;
                _dragOffset = e.Location;

                // Find source column
                var parent = _draggedTask?.Parent;
                while (parent != null && !(parent.Name.StartsWith("panel") && parent.Name != "panelMain"))
                {
                    parent = parent.Parent;
                }
                _sourceColumn = parent?.Name;
            }
        }

        private void TaskCard_MouseMove(object sender, MouseEventArgs e)
        {
            if (_draggedTask != null && e.Button == MouseButtons.Left)
            {
                var card = sender as Panel;
                card?.DoDragDrop(card.Tag, DragDropEffects.Move);
            }
        }

        private void TaskCard_MouseUp(object sender, MouseEventArgs e)
        {
            _draggedTask = null;
        }

        private void Column_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskModel)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void Column_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private async void Column_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskModel)))
            {
                var task = (TaskModel)e.Data.GetData(typeof(TaskModel));
                var targetPanel = sender as Panel;

                //if (targetPanel != null)
                //{
                //    var newStatus = GetStatusFromPanel(targetPanel.Name);

                //    if (newStatus != task.Status)
                //    {
                //        // Update task status
                //        await UpdateTaskStatus(task, newStatus);

                //        // Refresh the board
                //        RefreshBoard();
                //    }
                //}
            }
        }

        private string GetStatusFromPanel(string panelName)
        {
            switch (panelName)
            {
                case "panelToDo": return "Todo";
                case "panelInProgress": return "In Progress";
                case "panelReview": return "Review";
                case "panelDone": return "Done";
                default: return "Todo";
            }
        }

        //private async Task UpdateTaskStatus(TaskModel task, string newStatus)
        //{
        //    try
        //    {
        //        task.Status = newStatus;
        //        await _taskService.UpdateTaskAsync(task);

        //        // Update local list
        //        var localTask = _allTasks.FirstOrDefault(t => t.TaskId == task.TaskId);
        //        if (localTask != null)
        //        {
        //            localTask.Status = newStatus;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error updating task status: {ex.Message}", "Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        #endregion

        #region Event Handlers

        private void TaskCard_Click(object sender, EventArgs e)
        {
            if (sender is Panel card && card.Tag is TaskModel task)
            {
                // Open task details form or modal
                MessageBox.Show($"Task: {task.Name}\nProject: {task.ProjectName}\nStatus: {task.Status}\nPriority: {task.Priority}\n\nDescription:\n{task.Description}",
                    "Task Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxProjectFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProjectFilter.SelectedIndex == 0)
            {
                _selectedProjectId = -1; // All projects
            }
            else
            {
                // Extract project ID from the selected text
                var selectedText = comboBoxProjectFilter.SelectedItem.ToString();
                var startIndex = selectedText.LastIndexOf("ID: ") + 4;
                var endIndex = selectedText.LastIndexOf(")");

                if (int.TryParse(selectedText.Substring(startIndex, endIndex - startIndex), out int projectId))
                {
                    _selectedProjectId = projectId;
                }
            }

            RefreshBoard();
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        #endregion
    }

    // Extension method for drawing rounded rectangles
    public static class GraphicsExtensionsKanban
    {
        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle rect, int radius)
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

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}