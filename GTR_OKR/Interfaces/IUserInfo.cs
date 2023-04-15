using GTR_OKR.Models;

namespace GTR_OKR.Interfaces
{
    public interface IUserInfo
    {
        string CreateCompany(Company company);
        string EditCompany(Company company);
        List<Company> GetCompanyList();
        Company GetCompanyByEmail(string email);
        string CreateUser(User user);
        List<User> GetUserListByCom(int comId);
        List<User> GetUserListByDept(int dept);
        User GetUserById(int id);
        User GetUserByEmail(string email);
        string CreateDept(Department department);
        List<Department> GetDeptByCom(int comId);
        User GetDeptById(int id);

    }
}
