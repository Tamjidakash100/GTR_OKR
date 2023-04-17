using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class UserTaskAssign
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public Tasks Task { get; set; }
        public User User { get; set; }
    }
}
