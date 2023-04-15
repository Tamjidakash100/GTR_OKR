using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int ComId { get; set; }
        [ForeignKey(nameof(ComId))]
        [NotMapped]
        public Company Company { get; set; }
    }
}
