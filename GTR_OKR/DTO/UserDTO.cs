using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public int DeptId { get; set; }
        public int ComId { get; set; }
    }
}
