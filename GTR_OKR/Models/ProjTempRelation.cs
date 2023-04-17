using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.Models
{
    public class ProjTempRelation
    {
        public int PId { get; set; }
        public int TempId { get; set; }
        public Project Project { get; set; }
        public Template Template { get; set; }
    }
}
