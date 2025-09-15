using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void ProjectNameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProjectNameBox.Text) || ProjectNameBox.Text.Length < 3)
            {
                ProjectNameBox.BackColor = Color.LightCoral;
                toolTip1.SetToolTip(ProjectNameBox, "Project name must be at least 3 characters.");
            }
            else
            {
                ProjectNameBox.BackColor = Color.LightGreen;
                toolTip1.SetToolTip(ProjectNameBox, "Valid project name.");
            }
        }

        private void StarttextBox_TextChanged(object sender, EventArgs e)
        {
            if (!DateTime.TryParseExact(StarttextBox.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                StarttextBox.BackColor = Color.LightCoral;
                toolTip1.SetToolTip(StarttextBox, "Enter a valid Start Date (Format: yyyy-MM-dd).");
            }
            else
            {
                StarttextBox.BackColor = Color.LightGreen;
                toolTip1.SetToolTip(StarttextBox, "Valid Start Date.");
            }
        }

        private void EndDateTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!DateTime.TryParseExact(EndDateTxtBox.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                EndDateTxtBox.BackColor = Color.LightCoral;
                toolTip1.SetToolTip(EndDateTxtBox, "Enter a valid End Date (Format: yyyy-MM-dd).");
            }
            else
            {
                EndDateTxtBox.BackColor = Color.LightGreen;
                toolTip1.SetToolTip(EndDateTxtBox, "Valid End Date.");
            }
        }

        private void ProjectDescriptionBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProjectDescriptionBox.Text) || ProjectDescriptionBox.Text.Length < 10)
            {
                ProjectDescriptionBox.BackColor = Color.LightCoral;
                toolTip1.SetToolTip(ProjectDescriptionBox, "Description must be at least 10 characters.");
            }
            else
            {
                ProjectDescriptionBox.BackColor = Color.LightGreen;
                toolTip1.SetToolTip(ProjectDescriptionBox, "Valid  description.");
            }
        }

        private void ProjectSubmitBtn_Click(object sender, EventArgs e)
        {
            // Validate project name
            if (string.IsNullOrWhiteSpace(ProjectNameBox.Text) || ProjectNameBox.Text.Length < 3)
            {
                MessageBox.Show("❌ Project name is required (min 3 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate start date
            if (!DateTime.TryParseExact(StarttextBox.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate))
            {
                MessageBox.Show("❌ Enter a valid Start Date (Format: yyyy-MM-dd).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate end date
            if (!DateTime.TryParseExact(EndDateTxtBox.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime endDate))
            {
                MessageBox.Show("❌ Enter a valid End Date (Format: yyyy-MM-dd).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (endDate < startDate)
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

            // TODO: Save project details to database here
        }

        private void EndDateTxt_Click(object sender, EventArgs e)
        {

        }

        private void ProjectHeadTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
