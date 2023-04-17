using GTR_OKR.DTO;
using GTR_OKR.Models;

namespace GTR_OKR.Interfaces
{
    public interface IUserInfo
    {
        string CreateCompany(Company company);
        string EditCompany(CompanyDTO company);
        List<Company> GetCompanyList();
        Company GetCompanyByEmail(string email);
        string CreateUser(UserDTO user);
        List<User> GetUserListByCom(int comId);
        List<User> GetUserListByDept(int dept);
        User GetUserById(int id);
        User GetUserByEmail(string email);
        string CreateDept(DepartmentDTO department);
        List<Department> GetDeptByCom(int comId);
        Department GetDeptById(int id);
        List<User> GetUserListByTemp(int? tempId);
        List<User> GetUserListByTask(int? taskId);

    }
}
