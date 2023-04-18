using GTR_OKR.Models;

namespace GTR_OKR.Interfaces
{
    public interface IProject
    {
        string CreateProject(Project project);
        List<Project> GetAllProjectsByCom(int comId);
        List<Project> GetAllProjectsByOwner(int OwnerId);
        List<Project> GetAllProjectsByUser(int userId);
        string UpdateProject(Project project);
        string DeleteProject(Project project);
        string CreateUnd(List<Understanding> understanding);
        List<Understanding> GetUndByProj(int userId);
        string UpdateUnd(Understanding understanding);
        string DeleteUnd(int UndId);

    }
}
