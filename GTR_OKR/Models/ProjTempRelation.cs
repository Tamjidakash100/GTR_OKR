using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class ProjTempRelation
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int TempId { get; set; }
        [ForeignKey(nameof(PId))]
        public Project Project { get; set; }
        [ForeignKey(nameof(TempId))]
        public Template Template { get; set; }
    }
}
