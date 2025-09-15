using Bira.Models;
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
    public partial class EditTeam : Form
    {
        private readonly TeamService _teamService = new TeamService();
        private int _teamId;
        public EditTeam(int TeamId)
        {
            InitializeComponent();
            this.Load += EditTeam_Load;
            this._teamId = TeamId;
            // Configure panelTeamMembers to layout controls vertically
            panelTeamMembers.FlowDirection = FlowDirection.TopDown;
            panelTeamMembers.WrapContents = false;
            panelTeamMembers.AutoScroll = true;
            panelNonTeamMembers.FlowDirection = FlowDirection.TopDown;
            panelNonTeamMembers.WrapContents = false;
            panelNonTeamMembers.AutoScroll = true;
        }

        private void NewTeamHeadTxt_Click(object sender, EventArgs e)
        {

        }

        private async void EditTeam_Load(object sender, EventArgs e)
        {
            await LoadTeamDataAsync();
        }

        private async Task LoadTeamDataAsync()
        {
            var Teams = await _teamService.GetTeamsAsync();

            TeamModel currentTeam = null;

            foreach (var Team in Teams)
            {
                if (Team.TeamId == _teamId)
                {
                    EditTeamTxtBox.Text = Team.Name;
                    EditTeamDesTxtBox.Text = Team.TeamRole;
                    currentTeam = Team;
                    break;  // Found the team
                }
            }

            if (currentTeam == null)
            {
                MessageBox.Show("Team not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Clear panels before adding controls
            panelTeamMembers.Controls.Clear();
            panelNonTeamMembers.Controls.Clear();

            // 1. Populate Team Members Panel only once
            foreach (var member in currentTeam.Members)
            {
                var memberPanel = CreateMemberLabelPanel(member);
                panelTeamMembers.Controls.Add(memberPanel);
            }

            // 2. Build a unique list of all members (no duplicates)
            var allDistinctMembers = new List<MemberModel>();
            var addedMemberNames = new HashSet<string>();

            foreach (var Team in Teams)
            {
                foreach (var member in Team.Members)
                {
                    if (!addedMemberNames.Contains(member.Name))
                    {
                        allDistinctMembers.Add(member);
                        addedMemberNames.Add(member.Name);
                    }
                }
            }

            // 3. Calculate Non-Team Members properly
            var currentTeamMemberNames = new HashSet<string>(currentTeam.Members.Select(m => m.Name));

            var nonTeamMembers = allDistinctMembers
                .Where(m => !currentTeamMemberNames.Contains(m.Name))
                .ToList();

            // 4. Populate Non-Team Members Panel
            foreach (var member in nonTeamMembers)
            {
                var nonMemberPanel = CreateNonMemberLabelPanel(member);
                panelNonTeamMembers.Controls.Add(nonMemberPanel);
            }
        }




        private Panel CreateMemberLabelPanel(MemberModel member)
        {
            var memberPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Margin = new Padding(5),
                Padding = new Padding(5),

            };

            var memberLabel = new Label
            {
                Text = $"{member.Name} ({member.Role})",
                AutoSize = true,
                Font = new Font(this.Font.FontFamily, 10, FontStyle.Regular),
                Cursor = Cursors.Hand
            };

            var removeButton = new Button
            {
                Text = "Remove",
                AutoSize = true,
                Visible = false,
                Margin = new Padding(10, 0, 0, 0)
            };

            memberLabel.Click += (sender, e) =>
            {
                memberLabel.ForeColor = Color.Red;
                removeButton.Visible = true;
            };

            removeButton.Click += (sender, e) =>
            {
                panelTeamMembers.Controls.Remove(memberPanel);
                // Optionally: Track removed members for later save logic
            };

            memberPanel.Controls.Add(memberLabel);
            memberPanel.Controls.Add(removeButton);

            return memberPanel;
        }




        //private Label CreateMemberLabel(MemberModel member)
        //{
        //    var label = new Label
        //    {
        //        Text = $"{member.Name} ({member.Role})",
        //        AutoSize = true,
        //        Margin = new Padding(5),
        //        Font = new Font(this.Font.FontFamily, 10, FontStyle.Regular),
        //        Cursor = Cursors.Hand // Show pointer cursor to indicate clickable
        //    };

        //    label.Click += (sender, e) =>
        //    {
        //        var result = MessageBox.Show($"Remove {member.Name} from team?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (result == DialogResult.Yes)
        //        {
        //            panelTeamMembers.Controls.Remove(label);
        //            // Optional: Keep track of removed members in a list for saving later
        //        }
        //    };

        //    return label;
        //}


        private Panel CreateNonMemberLabelPanel(MemberModel member)
        {
            var nonMemberPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Margin = new Padding(5),
                Padding = new Padding(5),
            };

            var nonMemberLabel = new Label
            {
                Text = $"{member.Name} ({member.Role})",
                AutoSize = true,
                Font = new Font(this.Font.FontFamily, 10, FontStyle.Regular),
                ForeColor = Color.Black,
                Cursor = Cursors.Hand
            };

            var addButton = new Button
            {
                Text = "Add",
                AutoSize = true,
                Visible = false,
                Margin = new Padding(10, 0, 0, 0)
            };

            // On label click: highlight and show Add button
            nonMemberLabel.Click += (sender, e) =>
            {
                nonMemberLabel.ForeColor = Color.Green;
                addButton.Visible = true;
            };

            addButton.Click += (sender, e) =>
            {
                panelNonTeamMembers.Controls.Remove(nonMemberPanel);

                // Add member to Team Members panel
                var memberPanel = CreateMemberLabelPanel(member);
                panelTeamMembers.Controls.Add(memberPanel);

                // Optionally: Track added members for later saving
            };

            nonMemberPanel.Controls.Add(nonMemberLabel);
            nonMemberPanel.Controls.Add(addButton);

            return nonMemberPanel;
        }

    }
}
