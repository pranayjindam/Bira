using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bira.Models;

namespace Bira.Services
{
    internal class BacklogService
    {
        /// <summary>
        /// Simulates fetching a list of backlog items for a specific project.
        /// </summary>
        /// <param name="projectId">The ID of the project to get the backlog for.</param>
        /// <returns>A list of backlog item models.</returns>
        public async Task<List<BacklogModel>> GetBacklogItemsAsync() //int projectId
        {
            await Task.Delay(200); // Simulate async network call

            // In a real application, you would filter items by projectId here.
            // For this dummy service, we'll return a generic list.
            return new List<BacklogModel>
            {
                new BacklogModel
                {
                    ItemId = 201,
                    Title = "Implement User Authentication",
                    Description = "Set up user login and registration pages.",
                    Status = "In Progress",
                    Priority = "High",
                    ProjectId=1
                },
                new BacklogModel
                {
                    ItemId = 202,
                    Title = "Design Database Schema",
                    Description = "Define tables for users, projects, and tasks.",
                    Status = "To Do",
                    Priority = "High",
                    ProjectId=1
                },
                new BacklogModel
                {
                    ItemId = 203,
                    Title = "Develop Dashboard UI",
                    Description = "Create the main dashboard view with key metrics.",
                    Status = "To Do",
                    Priority = "Medium",
                    ProjectId=3
                },
                new BacklogModel
                {
                    ItemId = 204,
                    Title = "Add 'Export to PDF' Feature",
                    Description = "Allow users to export their project reports.",
                    Status = "To Do",
                    Priority = "Low",
                    ProjectId=3
                },
                 new BacklogModel
                {
                    ItemId = 205,
                    Title = "Refactor Payment Gateway",
                    Description = "Improve the integration with the payment provider.",
                    Status = "In Progress",
                    Priority = "Medium",
                    ProjectId=3
                }
            };
        }
    }
}
