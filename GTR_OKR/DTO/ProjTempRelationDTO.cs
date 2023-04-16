using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.DTO
{
    public class ProjTempRelationDTO
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int TempId { get; set; }
    }
}
