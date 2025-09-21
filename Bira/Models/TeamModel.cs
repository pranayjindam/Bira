namespace Bira.Models
{
    public class TeamModel
    {
        public int TeamId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<string> TeamMembers { get; set; } = new();
        public string TeamRole { get; set; } = string.Empty;

        public string TeamLead { get; set; } = string.Empty;

        public List<MemberModel> Members { get; set; } = new();
        public Dictionary<string, string> MemberRoles { get; set; } = new();
    }
}
