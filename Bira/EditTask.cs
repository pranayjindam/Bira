using Bira.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bira
{
    public partial class EditTask : Form
    {
        private readonly TaskService _taskService = new TaskService();
        private readonly ProjectService _projectService = new ProjectService();
        private int _taskId;

        public EditTask(int taskId)
        {
            InitializeComponent();
            this.Load += EditTask_Load;
            this._taskId = taskId;
            ApplyRoundedCorners();
        }

        private async void EditTask_Load(object sender, EventArgs e)
        {
            // --- Step 1: Populate ComboBoxes with all possible options ---

            // Populate Projects
            var projects = await _projectService.GetProjectsAsync();
            TasksProjectComboBox.Items.Clear();
            foreach (var project in projects)
            {
                TasksProjectComboBox.Items.Add(project.Name);
            }

            // Populate Priorities
            TasksPriorityComboBox.Items.Clear();
            TasksPriorityComboBox.Items.AddRange(new string[] { "Low", "Medium", "High", "Critical" });

            // Populate Statuses
            TaskStatusComboBox.Items.Clear();
            TaskStatusComboBox.Items.AddRange(new string[] { "Not Started", "In Progress", "Completed", "On Hold" });

            // --- Step 2: Find the specific task and set the current values ---
            var tasks = await _taskService.GetTasksAsync();
            var taskToEdit = tasks.FirstOrDefault(t => t.TaskId == _taskId);

            if (taskToEdit != null)
            {
                TasksNameTxtBox.Text = taskToEdit.Name;
                TasksProjectComboBox.SelectedItem = taskToEdit.ProjectName;
                TasksPriorityComboBox.SelectedItem = taskToEdit.Priority;
                TasksDesTxtBox.Text = taskToEdit.Description;
                TaskStatusComboBox.SelectedItem = taskToEdit.Status;
            }
            else
            {
                MessageBox.Show("Could not find the specified task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Add validation here if needed
            MessageBox.Show("Task updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // TODO: Add database update logic here
        }

        // Helper method for rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void ApplyRoundedCorners()
        {
            TasksPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TasksPanel.Width, TasksPanel.Height, 20, 20));
            TasksPanel.Resize += (s, e) => {
                TasksPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TasksPanel.Width, TasksPanel.Height, 20, 20));
            };
        }
    }
}