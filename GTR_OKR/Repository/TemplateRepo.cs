using GTR_OKR.Context;
using GTR_OKR.DTO;
using GTR_OKR.Interfaces;
using GTR_OKR.Models;

namespace GTR_OKR.Repository
{
    public class TemplateRepo : ITemplate
    {
        private readonly OkrDbContext _context;

        public TemplateRepo(OkrDbContext context)
        {
            _context = context; 
        }

        public string CreateTemp(TemplateDTO templateDTO)
        {
            Template template = new Template
            {
                Name = templateDTO.Name,
                OwnerId = templateDTO.OwnerId

            };

            _context.Templates.Add(template);
            var state = _context.SaveChanges();
            if (state > 0)
            {
                return "Successful";
            }
            return "Failed";
        }

        public string DeleteTemp(Template template)
        {
            _context.Templates.Remove(template);
            var state = (_context.SaveChanges());   
            if(state > 0) 
            {
                return "Delete Successful";
            }
            return "An Error Occurs..!!";
        }

        public string EditTemp(TemplateDTO templateDTO)
        {
            Template template = new Template
            {
                Name = templateDTO.Name,
                OwnerId = templateDTO.OwnerId

            };
            _context.Templates.Update(template);
            var state = (_context.SaveChanges());   
            if (state > 0) {
                return "Modify Successfull..";
            }
            return "An Error Occur..!!";
        }

        public List<Template> GetTempOwner(int Id)
        {
          var data =  _context.Templates.Where(x => x.OwnerId == Id).ToList();
         return data;
            
        }
    }
}
