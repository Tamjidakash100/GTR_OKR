using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class Template
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Template> Templates { get; set; }
        public int OwnerId { get; set; }
        [ForeignKey(nameof(User))]
        public User Owner { get; set; }
    }
}
