using System.Collections.Generic;
using System.Threading.Tasks;
using Bira.Models;

namespace Bira.Services
{
    public class ProjectService
    {
        public async Task<List<ProjectModel>> GetProjectsAsync()
        {
            await Task.Delay(200); // Simulate async call
            return new List<ProjectModel>
            {
                new ProjectModel
                {
                    ProjectId = 1,
                    Name = "Project Alpha",
                    Description = "This is a dummy description for Project Alpha",
                    StartDate = System.DateTime.Now.AddDays(-10),
                    EndDate = System.DateTime.Now.AddDays(20)
                },
                new ProjectModel
                {
                    ProjectId = 2,
                    Name = "Project Beta",
                    Description = "This is a dummy description for Project Beta",
                    StartDate = System.DateTime.Now.AddDays(-5),
                    EndDate = System.DateTime.Now.AddDays(15)
                },
                new ProjectModel
                {
                    ProjectId = 3,
                    Name = "Project Gamma",
                    Description = "This is a dummy description for Project Gamma",
                    StartDate = System.DateTime.Now.AddDays(-6),
                    EndDate = System.DateTime.Now.AddDays(17)
                },

            };
        }
        //public async Task DeleteProjectAsync(int projectId)
        //{
        //    await Task.Delay(100); // Simulate async database call

        //    var projectToRemove = _projects.FirstOrDefault(p => p.ProjectId == projectId);
        //    if (projectToRemove != null)
        //    {
        //        _projects.Remove(projectToRemove);
        //    }
        //}

        /// <summary>
        /// Simulates fetching a list of users asynchronously.
        /// </summary>
        /// <returns>A list of user models.</returns>
       
    }
}
