using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class UserProjectAssign
    {
        public int PId { get; set; }
        public int UserId { get; set; }
        public Project Project { get; set; }
        public User User { get; set; }
    }
}
