using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ComId { get; set;}
        public int ComAdminId { get; set;}
        [ForeignKey(nameof(ComAdminId))]
        public User Admin { get; set; }
    }
}
