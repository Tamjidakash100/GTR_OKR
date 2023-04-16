using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.DTO
{
    public class TasksDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime EstimatedDate { get; set; }
    }
}
