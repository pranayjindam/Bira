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
    public partial class NewTeam : Form
    {
        public NewTeam()
        {
            InitializeComponent();
            NewTeamAddBtn.Click += NewTeamAddBtn_Click; // attach event
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
    }
}
