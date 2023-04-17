using GTR_OKR.DTO;
using GTR_OKR.Models;

namespace GTR_OKR.Interfaces
{
    public interface ITemplate
    {
        string CreateTemp(TemplateDTO templateDTO);
        String EditTemp(TemplateDTO templateDTO);   
        String DeleteTemp(TemplateDTO templateDTO);
        List<Template> GetTempOwner(int uId);
    }
}
