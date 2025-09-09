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
            this.Load += new System.EventHandler(this.ForYouDashboard_Load);

        }

        private async void ForYouDashboard_Load(object sender, EventArgs e)
        {
            //await LoadRecentTasks();
            await LoadTaskProgressOverview();
            await LoadUserInfo();
        }


        private async Task LoadUserInfo()
        {
            var _userService = new UserService();
            var users = await _userService.GetUsersAsync();
            if (users == null || users.Count == 0)
            {
                MessageBox.Show("No users found.");
                return;
            }
            var user = users.First(); // Just get the first user for demo purposes
            labelWelcome.Text = $"Welcome, {user.FirstName}!";
            labelFirstname.Text = $"First Name : {user.FirstName}";
            labelLastname.Text = $"Last Name : {user.LastName}";
            labelEmail.Text = $"Email : {user.Email}";
            labelRole.Text = $"Role : {user.Role}";
        }

        //private async Task LoadRecentTasks()
        //{
        //    var _taskService = new TaskService();
        //    var tasks = await _taskService.GetTasksAsync();

        //    if (tasks == null || tasks.Count == 0)
        //    {
        //        MessageBox.Show("No tasks found.");
        //        return;
        //    }

        //    panelRecentTasks.Controls.Clear();
        //    panelRecentTasks.FlowDirection = FlowDirection.TopDown;
        //    panelRecentTasks.WrapContents = false;
        //    panelRecentTasks.AutoScroll = true;

        //    foreach (var task in tasks.Take(5))
        //    {
        //        // CHANGE 1: Use FlowLayoutPanel instead of Panel
        //        FlowLayoutPanel taskCard = new FlowLayoutPanel
        //        {
        //            Width = 300,
        //            AutoSize = true,
        //            AutoSizeMode = AutoSizeMode.GrowAndShrink,
        //            BackColor = Color.Chocolate,
        //            Margin = new Padding(5),
        //            Padding = new Padding(10),
        //            // CHANGE 2: Set its FlowDirection to stack controls vertically
        //            FlowDirection = FlowDirection.TopDown
        //        };

        //        Label lblTaskName = new Label
        //        {
        //            Text = $" {task.Name}",
        //            Font = new Font("Segoe UI", 12, FontStyle.Bold),
        //            ForeColor = Color.White,
        //            AutoSize = true,
        //            // Add a little margin to separate the labels
        //            Margin = new Padding(0, 0, 0, 5)
        //        };

        //        Label lblTaskStatus = new Label
        //        {
        //            // Using Task Name for more context
        //            Text = $"Status: {task.Status}",
        //            Font = new Font("Segoe UI", 10, FontStyle.Regular),
        //            ForeColor = Color.LightGray,
        //            AutoSize = true
        //        };

        //        taskCard.Controls.Add(lblTaskName);
        //        taskCard.Controls.Add(lblTaskStatus); // Now this will appear below the first label

        //        panelRecentTasks.Controls.Add(taskCard);
        //    }
        //}



        private async Task LoadTaskProgressOverview()
        {
            var _taskService = new TaskService();
            var tasks = await _taskService.GetTasksAsync();

            if (tasks == null || tasks.Count == 0)
            {
                MessageBox.Show("No tasks found.");
                return;
            }

            panelTaskProgress.Controls.Clear();
            panelTaskProgress.FlowDirection = FlowDirection.TopDown;
            panelTaskProgress.WrapContents = false;
            panelTaskProgress.AutoScroll = true;

            // Based on your TaskService, "InProgress" should be "In Progress" with a space
            var grouped = tasks.GroupBy(t => t.Status == "InProgress" ? "In Progress" : t.Status);

            foreach (var group in grouped)
            {
                string status = group.Key;
                int count = group.Count();

                Color bgColor = status switch
                {
                    "Pending" => Color.FromArgb(220, 68, 68),        // Red
                    "In Progress" => Color.FromArgb(108, 117, 125),  // Gray
                    "Completed" => Color.FromArgb(40, 167, 69),      // Green
                    _ => Color.FromArgb(100, 100, 100),              // Default gray
                };

                // CHANGE 1: Use FlowLayoutPanel instead of Panel
                FlowLayoutPanel statusCard = new FlowLayoutPanel
                {
                    Width = 300,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    BackColor = bgColor,
                    Margin = new Padding(5),
                    Padding = new Padding(10),
                    // CHANGE 2: Set its FlowDirection to stack controls vertically
                    FlowDirection = FlowDirection.TopDown
                };

                // I've used an icon from the Segoe MDL2 Assets font, common in Windows
                // Feel free to change the icon
                string icon = status switch
                {
                    "Pending" => "⏳",     // Hourglass icon
                    "Completed" => "✅",   // Checkmark icon
                    "In Progress" => "🔄", // Circular arrows icon
                    _ => "❔"              // Question mark for unknown status
                };

                Label lblStatusTitle = new Label
                {
                    Text = $"{icon} {status}",
                    Font = new Font("Segoe MDL2 Assets", 12, FontStyle.Regular), // Use icon font
                    ForeColor = Color.White,
                    AutoSize = false,
                    Width = 280, // Slightly less than card width for padding
                    TextAlign = ContentAlignment.MiddleLeft,
                    Margin = new Padding(0, 0, 0, 5)
                };

                Label lblStatusCount = new Label
                {
                    Text = $"{count} Tasks",
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    ForeColor = Color.White,
                    AutoSize = true
                };

                statusCard.Controls.Add(lblStatusTitle);
                statusCard.Controls.Add(lblStatusCount); // This will now appear below the title

                panelTaskProgress.Controls.Add(statusCard);
            }
        }

    }
}
