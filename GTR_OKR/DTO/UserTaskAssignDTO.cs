using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.DTO
{
    public class UserTaskAssignDTO
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
    }
}
