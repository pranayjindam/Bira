using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bira.Models;

namespace Bira.Services
{
    public class TeamService
    {
        // Dummy data
        public async Task<List<TeamModel>> GetTeamsAsync()
        {
            return await Task.FromResult(new List<TeamModel>
            {
                new TeamModel { TeamId=1,Name = "Alpha Team",TeamLead="Vishu", Members = new List<MemberModel>
                    {
                         
                        new MemberModel { Name = "Bharath", Role = "Developer" },
                        new MemberModel { Name = "pranay", Role = "Tester" }
                    }
                },
                new TeamModel { TeamId=2, Name = "Beta Team", TeamLead="Tharun", Members = new List<MemberModel>
                    {
                        new MemberModel { Name = "Naveen", Role = "Developer" }
                    }
                },
                new TeamModel { TeamId=3, Name = "Gamma Team", TeamLead="Pritham", Members = new List<MemberModel>
                    {
                        new MemberModel { Name = "tony", Role = "Debugger" },
                        new MemberModel {Name="shashank",Role="Devops"}
                    }
                }
            });
        }
    }
}
