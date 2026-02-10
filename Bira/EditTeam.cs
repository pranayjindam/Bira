using Bira.Models;
using Bira.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bira
{
    public partial class EditTeam : Form
    {
        private readonly TeamService _teamService = new TeamService();
        private int _teamId;

        public EditTeam(int teamId)
        {
            InitializeComponent();
            this.Load += EditTeam_Load;
            this._teamId = teamId;
            ApplyRoundedCorners();
        }

        private async void EditTeam_Load(object sender, EventArgs e)
        {
            await LoadTeamDataAsync();
        }

        private async Task LoadTeamDataAsync()
        {
            var teams = await _teamService.GetTeamsAsync();
            var currentTeam = teams.FirstOrDefault(t => t.TeamId == _teamId);

            if (currentTeam == null)
            {
                MessageBox.Show("Team not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            EditTeamTxtBox.Text = currentTeam.Name;
            EditTeamDesTxtBox.Text = currentTeam.TeamRole;
            EditTeamDesTxtBox.Text = currentTeam.TeamLead;

            panelTeamMembers.Controls.Clear();
            panelNonTeamMembers.Controls.Clear();

            var allMembers = teams.SelectMany(t => t.Members).GroupBy(m => m.Name).Select(g => g.First()).ToList();
            var currentTeamMemberNames = new HashSet<string>(currentTeam.Members.Select(m => m.Name));

            foreach (var member in allMembers)
            {
                if (currentTeamMemberNames.Contains(member.Name))
                {
                    panelTeamMembers.Controls.Add(CreateMemberPanel(member, true)); // Is a team member
                }
                else
                {
                    panelNonTeamMembers.Controls.Add(CreateMemberPanel(member, false)); // Is not a team member
                }
            }
        }

        private Panel CreateMemberPanel(MemberModel member, bool isTeamMember)
        {
            var memberCard = new Panel
            {
                Width = panelTeamMembers.ClientSize.Width - 15,
                Height = 50,
                BackColor = Color.FromArgb(50, 50, 65),
                Margin = new Padding(5),
                Tag = member
            };

            var memberLabel = new Label
            {
                Text = $"👤 {member.Name} ({member.Role})",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(10, 12),
                AutoSize = true
            };

            var actionButton = new Button
            {
                Text = isTeamMember ? "Remove" : "Add",
                BackColor = isTeamMember ? Color.IndianRed : Color.SeaGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(85, 30),
                Location = new Point(memberCard.Width - 95, 10),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            actionButton.FlatAppearance.BorderSize = 0;

            actionButton.Click += (sender, e) => ActionButton_Click(memberCard, member, !isTeamMember);

            memberCard.Controls.Add(memberLabel);
            memberCard.Controls.Add(actionButton);
            return memberCard;
        }

        private void ActionButton_Click(Panel memberCard, MemberModel member, bool addingMember)
        {
            if (addingMember)
            {
                panelNonTeamMembers.Controls.Remove(memberCard);
                panelTeamMembers.Controls.Add(CreateMemberPanel(member, true));
            }
            else
            {
                panelTeamMembers.Controls.Remove(memberCard);
                panelNonTeamMembers.Controls.Add(CreateMemberPanel(member, false));
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Team changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // TODO: Add logic to collect members from panelTeamMembers and save to the database.
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void ApplyRoundedCorners()
        {
            NewTeamPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NewTeamPanel.Width, NewTeamPanel.Height, 20, 20));
            NewTeamPanel.Resize += (s, e) => {
                NewTeamPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NewTeamPanel.Width, NewTeamPanel.Height, 20, 20));
            };
        }
    }
}