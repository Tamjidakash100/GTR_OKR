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
        List<UserDTO> GetUserListByCom(int comId);
        List<UserDTO> GetUserListByDept(int dept);
        UserDTO GetUserById(int id);
        UserDTO GetUserByEmail(string email);
        string CreateDept(DepartmentDTO department);
        List<Department> GetDeptByCom(int comId);
        UserDTO GetDeptById(int id);

    }
}
