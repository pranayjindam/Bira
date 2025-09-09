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
        }

        private void NewTeamHeadTxt_Click(object sender, EventArgs e)
        {

        }

        private void EditTeam_Load(object sender, EventArgs e)
        {
                        LoadTeamData();
        }

        private void LoadTeamData()
        {
            var team = _teamService.GetTeamsAsync();
            foreach (var t in team.Result)
            {
                if (t.TeamId == _teamId)
                {
                    NewTeamHeadTxt.Text = t.Head;
                    NewTeamDesTxtBox.Text = t.Description;
                }
            }
            if (teams != null)
            {
                NewTeamHeadTxt.Text = teams.Head;
                NewTeamDesTxtBox.Text = teams.Description;
            }
        }
    }
}
