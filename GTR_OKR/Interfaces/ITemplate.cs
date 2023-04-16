using GTR_OKR.DTO;
using GTR_OKR.Models;

namespace GTR_OKR.Interfaces
{
    public interface ITemplate
    {
        string CreateTemp(TemplateDTO templateDTO);
        String EditTemp(TemplateDTO templateDTO);   
        String DeleteTemp(Template templateDTO);
        List<Template> GetTempOwner(int uId);

        string CreateTask(TasksDTO tasks); 
        String UpdateTask(TasksDTO tasks);
        String DeleteTask(int id);
        List<Tasks> GetTaskListByTemp(int tId);

    }
}
