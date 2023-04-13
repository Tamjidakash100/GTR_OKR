using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class UserTaskAssign
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(TaskId))]
        public Tasks Task { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
