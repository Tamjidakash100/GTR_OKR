using GTR_OKR.Interfaces;
using GTR_OKR.Models;

namespace GTR_OKR.Repository
{
    public class ProjectRepo : IProject
    {
        public string CreateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public string CreateUnd(List<Understanding> understanding)
        {
            throw new NotImplementedException();
        }

        public string DeleteProject(Project project)
        {
            throw new NotImplementedException();
        }

        public string DeleteUnd(int UndId)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllProjectsByCom(int comId)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllProjectsByOwner(int OwnerId)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllProjectsByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Understanding> GetUndByProj(int userId)
        {
            throw new NotImplementedException();
        }

        public string UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public string UpdateUnd(Understanding understanding)
        {
            throw new NotImplementedException();
        }
    }
}
