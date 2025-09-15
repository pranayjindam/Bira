using Bira.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bira.Services;

namespace Bira
{
    public partial class EditTask : Form
    {
        private readonly TaskService _taskService = new TaskService();
        private readonly ProjectService _projectService = new ProjectService();

        private int _taskId;
        public EditTask(int TaskId)
        {
            InitializeComponent();
            this.Load += EditTask_Load;
            this._taskId = TaskId;

        }


        private async void EditTask_Load(object sender, EventArgs e)
        {
            // Populate Project ComboBox first
            var projects = await _projectService.GetProjectsAsync();
            TasksProjectComboBox.Items.Clear();
            foreach (var project in projects)
            {
                TasksProjectComboBox.Items.Add(project.Name);
            }

            // Populate Status ComboBox (example fixed statuses)
            TaskStatusComboBox.Items.Clear();
            var statuses = new List<string> { "Pending", "In Progress", "Completed", "Blocked" };
            foreach (var status in statuses)
            {
                TaskStatusComboBox.Items.Add(status);
            }

            // Find and display the task data
            var tasks = await _taskService.GetTasksAsync();
            foreach (var task in tasks)
            {
                if (_taskId == task.TaskId)
                {
                    TasksNameTxtBox.Text = task.Name;
                    TasksProjectComboBox.SelectedItem = task.ProjectName;
                    TasksPriorityComboBox.Text = task.Priority;
                    TasksDesTxtBox.Text = task.Description;
                    TaskStatusComboBox.SelectedItem = task.Status;
                }
            }
        }

    }
}
