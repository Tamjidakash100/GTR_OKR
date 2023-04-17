using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class Template
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Tasks> Tasks { get; set; }
        public List<ProjTempRelation> PTemplates { get; set; }
        public int OwnerId { get; set; }
        public User Owner { get; set; }
        public List<UserTempAssign> UserTemps { get; set; }
    }
}
