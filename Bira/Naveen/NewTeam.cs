using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bira.Naveen
{
    public partial class NewTeam : Form
    {
        public NewTeam()
        {
            InitializeComponent();
            // Apply rounded corners to the main panel after it's initialized
            ApplyRoundedCorners();
        }

        private void NewTeamAddBtn_Click(object sender, EventArgs e)
        {
            string teamName = NewTeamTxtBox.Text.Trim();
            string description = NewTeamDesTxtBox.Text.Trim();

            // ✅ Validation
            if (string.IsNullOrWhiteSpace(teamName) || teamName.Length < 3)
            {
                MessageBox.Show("❌ Team name must be at least 3 characters.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(description) || description.Length < 5)
            {
                MessageBox.Show("❌ Description must be at least 5 characters.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // ✅ Show entered details in dialog
            DialogResult result = MessageBox.Show(
                $"✅ New Team Added Successfully!\n\n" +
                $"👥 Team Name: {teamName}\n" +
                $"📝 Description: {description}",
                "Team Added",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.OK)
            {
                // (Optional) Reset fields after adding
                NewTeamTxtBox.Clear();
                NewTeamDesTxtBox.Clear();
                NewTeamTxtBox.Focus();
            }
        }

        // Helper for rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void ApplyRoundedCorners()
        {
            // Apply rounded corners to the main panel
            NewTeamPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NewTeamPanel.Width, NewTeamPanel.Height, 20, 20));

            // Re-apply if the panel is resized
            NewTeamPanel.Resize += (s, e) => {
                NewTeamPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NewTeamPanel.Width, NewTeamPanel.Height, 20, 20));
            };
        }
    }
}