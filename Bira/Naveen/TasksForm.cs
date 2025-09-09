using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bira.Naveen
{
    public partial class TasksForm : Form
    {
        private ToolTip toolTip1;

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
    }
}
