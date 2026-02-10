using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bira.Services;

namespace Bira
{
    public partial class EditProject : Form
    {
        private readonly ProjectService _projectService = new ProjectService();
        private int _projectId;

        public EditProject(int projectId)
        {
            InitializeComponent();
            this.Load += EditProject_Load;
            this._projectId = projectId;
            ApplyRoundedCorners();
        }

        private async void EditProject_Load(object sender, EventArgs e)
        {
            var projects = await _projectService.GetProjectsAsync();
            var projectToEdit = projects.FirstOrDefault(p => p.ProjectId == _projectId);

            if (projectToEdit != null)
            {
                ProjectNameBox.Text = projectToEdit.Name;
                ProjectDescriptionBox.Text = projectToEdit.Description;

                // Set the values for the DateTimePicker controls
                startDatePicker.Value = projectToEdit.StartDate;
                endDatePicker.Value = projectToEdit.EndDate;
            }
            else
            {
                MessageBox.Show("Project not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ProjectSubmitBtn_Click(object sender, EventArgs e)
        {
            // Simple validation
            if (endDatePicker.Value < startDatePicker.Value)
            {
                MessageBox.Show("End date cannot be earlier than the start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Project updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // TODO: Add logic to save the updated project details to your database
        }

        // Helper method for rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void ApplyRoundedCorners()
        {
            ProjectPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ProjectPanel.Width, ProjectPanel.Height, 20, 20));
            ProjectPanel.Resize += (s, e) => {
                ProjectPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ProjectPanel.Width, ProjectPanel.Height, 20, 20));
            };
        }
    }
}