using GTR_OKR.Context;
using GTR_OKR.Interfaces;
using GTR_OKR.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Web.Http.ModelBinding;
using GTR_OKR.Models;

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

        public string CreateDept(DepartmentDTO department)
        {
            Department dp = new Department
            {
                Id = department.Id,
                DepartmentName = department.DepartmentName,
                ComId = department.ComId,

            };
            _db.Departments.Add(dp);
           var state = _db.SaveChanges();
            if(state >0)
            {
                return "Successfull";
                    
            }
            return "Failed";
        }

        public string CreateUser(UserDTO user)
        {
            _db.Add(user);
            var state = _db.SaveChanges();
            if (state >0)
            {
                return "Successful";
            }
            return "Failed";
        }

        public string EditCompany(CompanyDTO company)
        {
            Company com = new Company
            {
                Id = company.Id,
                CompanyName = company.CompanyName,
                ComId = company.ComId,
                Email = company.Email
            };
            _db.Companies.Update(com);
            var state = _db.SaveChanges();
            if (state >0)
            {
                return "Successful";
            }
            return "Failed";
        }

        public Company GetCompanyByEmail(string email)
        {
            Company company =  _db.Companies.FirstOrDefault(c=>c.Email==email) ;
            
            return company;
        }

        public List<Company> GetCompanyList()
        {
            return _db.Companies.ToList();
        }

        public List<Department> GetDeptByCom(int comId)
        {
            List<Department> depList= _db.Departments.Where(c=>c.ComId==comId).ToList();
            return depList;
        }

        public Department GetDeptById(int id)
        {
            return _db.Departments.Include(c=>c.Company).FirstOrDefault(c=>c.Id==id);
        }

        public User GetUserByEmail(string email)
        {
            return _db.Users.FirstOrDefault(c=>c.Email==email);
        }

        public User GetUserById(int id)
        {
            return _db.Users.FirstOrDefault(c => c.Id == id);
        }

        public List<User> GetUserListByCom(int comId)
        {
            return _db.Users.Where(c=>c.ComId==comId).ToList();
        }

        public List<User> GetUserListByDept(int deptId)
        {
            return _db.Users.Where(c => c.DeptId == deptId).ToList();
        }
    }
}
