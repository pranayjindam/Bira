using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bira.Models;
using Bira.Services;

namespace Bira.Naveen
{
    public partial class TasksForm : Form
    {
        private ToolTip toolTip1;
        private readonly ProjectService _projectService = new ProjectService();
        private readonly TeamService _teamService = new TeamService();
        private readonly TaskService _taskService = new TaskService();

        public TasksForm()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            
        }

        private void TasksSubmitBtn_Click(object sender, EventArgs e)
        {
            // Validate Task Name
            if (string.IsNullOrWhiteSpace(TasksNameTxtBox.Text) || TasksNameTxtBox.Text.Length < 3)
            {
                MessageBox.Show("❌ Task name is required (min 3 characters).",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TasksNameTxtBox.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                TasksNameTxtBox.BackColor = Color.LightGreen;
            }

            // Validate Project Selection
            if (TasksProjectNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("❌ Please select a project.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Description
            if (string.IsNullOrWhiteSpace(TasksDesTxtBox.Text) || TasksDesTxtBox.Text.Length < 10)
            {
                MessageBox.Show("❌ Description is required (min 10 characters).",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TasksDesTxtBox.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                TasksDesTxtBox.BackColor = Color.LightGreen;
            }

            // Validate Priority
            if (TasksPriorityComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("❌ Please select a priority.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Status
            if (TasksStatusComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("❌ Please select a status.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ All validations passed
            string taskName = TasksNameTxtBox.Text.Trim();
            string projectName = TasksProjectNameComboBox.SelectedItem.ToString();
            string description = TasksDesTxtBox.Text.Trim();
            string priority = TasksPriorityComboBox.SelectedItem.ToString();
            string status = TasksStatusComboBox.SelectedItem.ToString();

            MessageBox.Show(
                $"✅ Task Submitted Successfully!\n\n" +
                $"📌 Task Name: {taskName}\n" +
                $"📂 Project: {projectName}\n" +
                $"📝 Description: {description}\n" +
                $"⭐ Priority: {priority}\n" +
                $"📊 Status: {status}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            // TODO: Save to database here
        }

        private async void TasksForm_Load(object sender, EventArgs e)
        {
            // Populate Project ComboBox with dummy data
            var projects = await _projectService.GetProjectsAsync();
            List<string> names = new List<string>();
            foreach (var project in projects)
            {
                TasksProjectNameComboBox.Items.Add(project.Name);

            }

            // Populate Priority ComboBox
            TasksPriorityComboBox.Items.AddRange(new string[]
            {
                "Low",
                "Medium",
                "High",
                "Critical"
            });
            // Populate Status ComboBox
            TasksStatusComboBox.Items.AddRange(new string[]
            {
                "Not Started",
                "In Progress",
                "Completed",
                "On Hold"
            });
            // Set default selections
            TasksPriorityComboBox.SelectedIndex = 0; // Default to Low
            TasksStatusComboBox.SelectedIndex = 0;   // Default to Not Started
            // Set up tooltips
            toolTip1.SetToolTip(TasksNameTxtBox, "Enter the name of the task (min 3 characters).");
            toolTip1.SetToolTip(TasksProjectNameComboBox, "Select the project this task belongs to.");
            toolTip1.SetToolTip(TasksDesTxtBox, "Enter a detailed description of the task (min 10 characters).");
            toolTip1.SetToolTip(TasksPriorityComboBox, "Select the priority level of the task.");
            toolTip1.SetToolTip(TasksStatusComboBox, "Select the current status of the task.");
        }
    }
}
