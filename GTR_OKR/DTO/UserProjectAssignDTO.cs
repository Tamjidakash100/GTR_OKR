using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.DTO
{
    public class UserProjectAssignDTO
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int UserId { get; set; }
    }
}
