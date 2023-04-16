using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.DTO
{
    public class TemplateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
    }
}
