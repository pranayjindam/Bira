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

namespace Bira
{
    public partial class EditProject : Form
    {
        private readonly ProjectService _projectService = new ProjectService();
        private readonly TeamService _teamService = new TeamService();
        private readonly TaskService _taskService = new TaskService();
        
        private int _projectId;
        public EditProject(int projectId)
        {
            InitializeComponent();
            this.Load += EditProject_Load;
            this._projectId = projectId;
        }

        private async void EditProject_Load(object sender, EventArgs e)
        {
            // Populate Project ComboBox with dummy data
            var projects = await _projectService.GetProjectsAsync();
            foreach (var project in projects)
            {
                if (project.ProjectId == _projectId)
                { 
                ProjectNameBox.Text = project.Name;
                StarttextBox.Text = project.StartDate.ToString();
                EndDateTxtBox.Text = project.EndDate.ToString();
                ProjectDescriptionBox.Text = project.Description;
                }
            }
        }

        private void ProjectSubmitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
