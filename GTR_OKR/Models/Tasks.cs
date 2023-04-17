using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime EstimatedDate { get; set; }
        public int TempId { get; set; }
        [ForeignKey(nameof(TempId))]
        public Template Template { get; set; }
        [ForeignKey(nameof(PId))]
        public Project Project { get; set; }
        public List<UserTaskAssign> UserTasks { get; set; }
    }
}
