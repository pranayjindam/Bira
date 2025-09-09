using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bira.Models
{
    internal class BacklogModel
    {
        public int ItemId { get; set; }
        public string Title { get; set; } = "Untitled Task";
        public string Description { get; set; } = "";
        public string Status { get; set; } = "To Do"; // e.g., "To Do", "In Progress", "Done"
        public string Priority { get; set; } = "Medium"; // e.g., "High", "Medium", "Low"
    }
}
