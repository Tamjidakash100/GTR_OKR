using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class UserTempAssign
    {
        public int Id { get; set; }
        public int TempId { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(TempId))]
        public Template Template { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
