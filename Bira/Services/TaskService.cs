using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Bira.Models;

namespace Bira.Services
{
    public class TaskService
    {
        private static List<TaskModel> _tasks = new List<TaskModel>();
        public async Task<List<TaskModel>> GetTasksAsync()
        {
            await Task.Delay(200); // Simulate async call
            return new List<TaskModel>
            {
                new TaskModel
                {
                    TaskId = 101,
                    Name = "Task One",
                    ProjectId = 1,
                    ProjectName = "Project Alpha",
                    Description = "Dummy task description",
                    Priority = "Low",
                    Status = "Pending"
                },
                new TaskModel
                {
                    TaskId = 102,
                    Name = "Task Two",
                    ProjectId = 2,
                    ProjectName = "Project Beta",
                    Description = "Dummy task description",
                    Priority = "Medium",
                    Status = "Completed"
                },
                new TaskModel
                {
                    TaskId = 103,
                    Name = "Task Three",
                    ProjectId = 1,
                    ProjectName = "Project Alpha",
                    Description = "Dummy task description",
                    Priority = "Low",
                    Status = "InProgress"
                }
            };
        }

    }
}
