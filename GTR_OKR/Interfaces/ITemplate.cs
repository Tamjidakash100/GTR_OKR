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
        string CreateTask(TasksDTO tasks);
        List<Tasks> GetTaskListByTemp(int tId);
        string UpdateTask(TasksDTO task);
        string DeleteTask(int id);
        List<Tasks> GetTaskListByUser(int? userId);
        bool UserExists(int? userId);
        List<Template> GetTempListByUser(int? userId);
    }
}
