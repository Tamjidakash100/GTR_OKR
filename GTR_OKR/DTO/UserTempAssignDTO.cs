using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.DTO
{
    public class UserTempAssignDTO
    {
        public int Id { get; set; }
        public int TempId { get; set; }
        public int UserId { get; set; }
    }
}
