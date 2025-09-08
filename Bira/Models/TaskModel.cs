namespace Bira.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }
        public string Priority { get; set; } = "M"; // H/M/L
        public string Status { get; set; } = "Pending"; // InProgress, Completed etc.
    }
}
