using Bira.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using Bira.UiHelper;   // <-- this already has GraphicsExtensions
using Bira.UI;
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

        // Helper for rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private async void ForYouDashboard_Load(object sender, EventArgs e)
        {
            // Apply rounded corners to the main panels
            panelUserInfo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelUserInfo.Width, panelUserInfo.Height, 20, 20));
            panelTaskProgressContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTaskProgressContainer.Width, panelTaskProgressContainer.Height, 20, 20));

            // Add paint events for borders
            panelUserInfo.Paint += (s, e) => DrawPanelBorder(e, panelUserInfo);
            panelTaskProgressContainer.Paint += (s, e) => DrawPanelBorder(e, panelTaskProgressContainer);

            await LoadTaskProgressOverview();
            await LoadUserInfo();
        }

        private void DrawPanelBorder(PaintEventArgs e, Panel panel)
        {
            using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 2))
            {
                // Use the extension from Bira.UiHelper.GraphicsExtensions
                e.Graphics.DrawRoundedRectangle(borderPen, new Rectangle(1, 1, panel.Width - 3, panel.Height - 3), 18);
            }
        }

        private async Task LoadUserInfo()
        {
            var _userService = new UserService();
            var users = await _userService.GetUsersAsync();
            if (users == null || !users.Any())
            {
                labelWelcome.Text = "Welcome, User!";
                labelFullName.Text = "User Name";
                labelEmail.Text = "user@email.com";
                labelRole.Text = "Team Lead";
                return;
            }

            var user = users.First(); // Using the first user for this demo
            labelWelcome.Text = $"Hello, {user.FirstName}!";
            labelFullName.Text = $"{user.FirstName} {user.LastName}";
            labelEmail.Text = user.Email;
            labelRole.Text = user.Role;
        }

        private async Task LoadTaskProgressOverview()
        {
            var _taskService = new TaskService();
            var tasks = await _taskService.GetTasksAsync();

            if (tasks == null || !tasks.Any())
            {
                Label noTasksLabel = new Label
                {
                    Text = "No tasks found.",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(107, 114, 128),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                panelTaskProgress.Controls.Add(noTasksLabel);
                return;
            }

            panelTaskProgress.Controls.Clear();

            var grouped = tasks.GroupBy(t => t.Status);

            foreach (var group in grouped)
            {
                string status = group.Key;
                int count = group.Count();

                Color statusColor = status switch
                {
                    "Pending" => Color.FromArgb(239, 68, 68),      // Red-500
                    "In Progress" => Color.FromArgb(59, 130, 246), // Blue-500  
                    "Completed" => Color.FromArgb(16, 185, 129),   // Emerald-500
                    _ => Color.FromArgb(107, 114, 128),            // Gray-500
                };

                string icon = status switch
                {
                    "Pending" => "⏳",
                    "Completed" => "✅",
                    "In Progress" => "🔄",
                    _ => "❔"
                };

                // Main card container
                Panel statusCard = new Panel
                {
                    Width = panelTaskProgress.Width - 25,
                    Height = 95,
                    BackColor = Color.FromArgb(248, 250, 252),
                    Margin = new Padding(10),
                    Padding = new Padding(15)
                };
                statusCard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, statusCard.Width, statusCard.Height, 15, 15));

                // Add paint event for card border
                statusCard.Paint += (s, e) =>
                {
                    using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 1))
                    {
                        e.Graphics.DrawRoundedRectangle(borderPen, new Rectangle(0, 0, statusCard.Width - 1, statusCard.Height - 1), 15);
                    }
                };

                // Status title label
                Label lblStatusTitle = new Label
                {
                    Text = $"{icon} {status}",
                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 41, 59),
                    Dock = DockStyle.Top,
                    Height = 35,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                // Status count label
                Label lblStatusCount = new Label
                {
                    Text = $"{count} Tasks",
                    Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                    ForeColor = statusColor,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                statusCard.Controls.Add(lblStatusCount);
                statusCard.Controls.Add(lblStatusTitle);

                panelTaskProgress.Controls.Add(statusCard);
            }
        }
    }
}
