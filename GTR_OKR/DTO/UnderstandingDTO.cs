using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.DTO
{
    public class UnderstandingDTO
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
