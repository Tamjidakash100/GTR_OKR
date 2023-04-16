using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.DTO
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ComId { get; set;}
        [EmailAddress]
        public string Email { get; set; }
    }
}
