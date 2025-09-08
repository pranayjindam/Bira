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
    public partial class ForYouDashboard : Form
    {
        public ForYouDashboard()
        {
            InitializeComponent();
        }

        private async void ForYouDashboard_Load(object sender, EventArgs e)
        {
            await LoadRecentTasks();
        }

        private async Task LoadRecentTasks()
        {
            var _taskService = new TaskService();
            var tasks = await _taskService.GetTasksAsync();

            panelRecentTasks.Controls.Clear();

            foreach (var task in tasks.Take(5))  // Show last 5 tasks
            {
                Panel taskCard = new Panel
                {
                    Width = 200,
                    Height = 100,
                    BackColor = Color.FromArgb(50, 50, 70),
                    Margin = new Padding(5),
                    Padding = new Padding(10)
                };

                Label lblTaskName = new Label
                {
                    Text = $"📝 {task.Name}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = true
                };

                Label lblTaskStatus = new Label
                {
                    Text = $"Status: {task.Status}",
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    ForeColor = Color.LightGray,
                    AutoSize = true
                };

                taskCard.Controls.Add(lblTaskName);
                taskCard.Controls.Add(lblTaskStatus);

                panelRecentTasks.Controls.Add(taskCard);
            }
        }
    }
}
