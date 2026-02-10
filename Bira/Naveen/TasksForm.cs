using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bira.Services;

namespace Bira.Naveen
{
    public partial class TasksForm : Form
    {
        private ToolTip toolTip1;
        private readonly ProjectService _projectService = new ProjectService();

        public TasksForm()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
        }

        private async void TasksForm_Load(object sender, EventArgs e)
        {
            // Populate Project ComboBox
            var projects = await _projectService.GetProjectsAsync();
            foreach (var project in projects)
            {
                TasksProjectNameComboBox.Items.Add(project.Name);
            }

            // Populate Priority ComboBox
            TasksPriorityComboBox.Items.AddRange(new string[] { "Low", "Medium", "High", "Critical" });

            // Populate Status ComboBox
            TasksStatusComboBox.Items.AddRange(new string[] { "Not Started", "In Progress", "Completed", "On Hold" });

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

        private void TasksNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Real-time validation for Task Name
            if (string.IsNullOrWhiteSpace(TasksNameTxtBox.Text) || TasksNameTxtBox.Text.Length < 3)
            {
                panelTaskNameUnderline.BackColor = Color.IndianRed;
            }
            else
            {
                panelTaskNameUnderline.BackColor = Color.LightGreen;
            }
        }

        private void TasksSubmitBtn_Click(object sender, EventArgs e)
        {
            // Validate Task Name
            if (string.IsNullOrWhiteSpace(TasksNameTxtBox.Text) || TasksNameTxtBox.Text.Length < 3)
            {
                MessageBox.Show("❌ Task name is required (min 3 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Project Selection
            if (TasksProjectNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("❌ Please select a project.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Description
            if (string.IsNullOrWhiteSpace(TasksDesTxtBox.Text) || TasksDesTxtBox.Text.Length < 10)
            {
                MessageBox.Show("❌ Description is required (min 10 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Priority and Status are validated by ensuring an item is selected
            if (TasksPriorityComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("❌ Please select a priority.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TasksStatusComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("❌ Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ All validations passed
            string taskName = TasksNameTxtBox.Text.Trim();
            string projectName = TasksProjectNameComboBox.SelectedItem.ToString();
            string description = TasksDesTxtBox.Text.Trim();
            string priority = TasksPriorityComboBox.SelectedItem.ToString();
            string status = TasksStatusComboBox.SelectedItem.ToString();

            MessageBox.Show(
                $"✅ Task Created Successfully!\n\n" +
                $"📌 Task Name: {taskName}\n" +
                $"📂 Project: {projectName}\n" +
                $"📝 Description: {description}\n" +
                $"⭐ Priority: {priority}\n" +
                $"📊 Status: {status}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            // TODO: Save to database here
        }
    }
}