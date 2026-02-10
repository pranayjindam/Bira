using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bira.Naveen
{
    public partial class ProjectForm : Form
    {
        private ToolTip toolTip1;

        public ProjectForm()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            ApplyRoundedCorners(); // Apply rounded corners on load
        }

        // --- VALIDATION FEEDBACK METHODS ---

        private void ProjectNameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProjectNameBox.Text) || ProjectNameBox.Text.Length < 3)
            {
                ProjectNameBox.ForeColor = Color.IndianRed;
                panelNameUnderline.BackColor = Color.IndianRed;
                toolTip1.SetToolTip(ProjectNameBox, "Project name must be at least 3 characters.");
            }
            else
            {
                ProjectNameBox.ForeColor = Color.White;
                panelNameUnderline.BackColor = Color.LightGreen;
                toolTip1.SetToolTip(ProjectNameBox, "Valid project name.");
            }
        }

        // REMOVED: StarttextBox_TextChanged and EndDateTxtBox_TextChanged are no longer needed.

        private void ProjectDescriptionBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProjectDescriptionBox.Text) || ProjectDescriptionBox.Text.Length < 10)
            {
                ProjectDescriptionBox.ForeColor = Color.IndianRed;
                toolTip1.SetToolTip(ProjectDescriptionBox, "Description must be at least 10 characters.");
            }
            else
            {
                ProjectDescriptionBox.ForeColor = Color.White;
                toolTip1.SetToolTip(ProjectDescriptionBox, "Valid description.");
            }
        }

        // --- SUBMIT BUTTON CLICK ---

        private void ProjectSubmitBtn_Click(object sender, EventArgs e)
        {
            // Validate project name
            if (string.IsNullOrWhiteSpace(ProjectNameBox.Text) || ProjectNameBox.Text.Length < 3)
            {
                MessageBox.Show("❌ Project name is required (min 3 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // MODIFIED: Get dates directly from the DateTimePicker controls. No parsing needed!
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            if (endDate.Date < startDate.Date) // Use .Date to compare only the date part
            {
                MessageBox.Show("❌ End Date cannot be earlier than Start Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate description
            if (string.IsNullOrWhiteSpace(ProjectDescriptionBox.Text) || ProjectDescriptionBox.Text.Length < 10)
            {
                MessageBox.Show("❌ Description is required (min 10 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ All validations passed
            MessageBox.Show("✅ Project submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- UI HELPER METHODS ---

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