using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTR_OKR.DTO
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime EstDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int Progress { get; set; }
        public List<string> Tags { get; set; }
        public int ComId { get; set; }
        public int OwnerId { get; set; }
        public int TempId { get; set; }
        public int UndId { get; set; }
        public int DeptId { get; set; }
    }
}
