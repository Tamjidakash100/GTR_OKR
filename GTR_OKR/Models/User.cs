using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class User
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
        [ForeignKey(nameof(DeptId))]
        public Department Department { get; set; }
        [ForeignKey(nameof(ComId))]
        public Company Company { get; set; }
        public List<UserTaskAssign> UserTasks { get; set; }
        public List<UserProjectAssign> UserProjects { get; set; }
        public List<UserTempAssign> UserTemps { get; set; }
    }
}
