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
                new TeamModel { Name = "Alpha Team", Members = new List<MemberModel>
                    {
                        new MemberModel { Name = "John", Role = "Developer" },
                        new MemberModel { Name = "Alice", Role = "Tester" }
                    }
                },
                new TeamModel { Name = "Beta Team", Members = new List<MemberModel>
                    {
                        new MemberModel { Name = "Bob", Role = "Developer" }
                    }
                },
                 new TeamModel { Name = "Gamma Team", Members = new List<MemberModel>
                    {
                        new MemberModel { Name = "tony", Role = "debugger" },
                        new MemberModel {Name="shashank",Role="data engineer"}
                    }
                }
            });
        }
    }
}
