using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class UserProjectAssign
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(PId))]
        public Project Project { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
