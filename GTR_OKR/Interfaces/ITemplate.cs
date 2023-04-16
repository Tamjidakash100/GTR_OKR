using GTR_OKR.DTO;
using GTR_OKR.Models;

namespace GTR_OKR.Interfaces
{
    public interface ITemplate
    {
        string CreateTemp(TemplateDTO templateDTO);
        String EditTemp(TemplateDTO templateDTO);   
        String DeleteTemp(Template templateDTO);
        List<Template> GetTempProj(int pid);
    }
}
