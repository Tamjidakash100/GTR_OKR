using GTR_OKR.Context;
using GTR_OKR.Interfaces;
using GTR_OKR.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Web.Http.ModelBinding;

namespace GTR_OKR.Repository
{
    public class UserRepo : IUserInfo
    {
        OkrDbContext _db;
        public UserRepo(OkrDbContext db)
        {
            _db = db;
        }
        public string CreateCompany(Company company)
        {
            _db.Companies.Add(company);
            var state = _db.SaveChanges();
            if (state >0)
            {
                return "Successful";
            }
            return "Failed";
        }

        public string CreateDept(Department department)
        {
            throw new NotImplementedException();
        }

        public string CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Company GetCompanyByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetCompanyList()
        {
            throw new NotImplementedException();
        }

        public List<User> GetDeptByCom(int comId)
        {
            throw new NotImplementedException();
        }

        public User GetDeptById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUserListByCom(int comId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUserListByDept(int dept)
        {
            throw new NotImplementedException();
        }
    }
}
