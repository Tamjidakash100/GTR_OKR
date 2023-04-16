using GTR_OKR.Context;
using GTR_OKR.Interfaces;
using GTR_OKR.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Web.Http.ModelBinding;
using GTR_OKR.Models;
using AutoMapper;

namespace GTR_OKR.Repository
{
    public class UserRepo : IUserInfo
    {
        OkrDbContext _db;
        private readonly IMapper _mapper;

        public UserRepo(OkrDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        //controller done..
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

        //controller done..
        public string CreateDept(DepartmentDTO department)
        {
            //Department dept = new Department
            //{
            //    Id = department.Id,
            //    DepartmentName = department.DepartmentName,
            //    ComId = department.ComId,

            //};
            var dept = _mapper.Map<Department>(department);
            _db.Departments.Add(dept);
           var state = _db.SaveChanges();
            if(state >0)
            {
                return "Successful";
                    
            }
            return "Failed";
        }

        //controller done..
        public string CreateUser(UserDTO user)
        {
            User userInfo = new User
            {
                UserId = user.UserId,
                Name = user.Name,
                Email = user.Email,
                Phone = user.Phone,
                Role = user.Role,
                ComId = user.ComId,
                DeptId = user.DeptId
            };
            _db.Add(userInfo);
            var state = _db.SaveChanges();
            if (state >0)
            {
                return "Successful";
            }
            return "Failed";
        }

        //controller done..
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

        //controller done..
        public Company GetCompanyByEmail(string email)
        {
            Company company =  _db.Companies.FirstOrDefault(c=>c.Email==email) ;
            
            return company;
        }
        //controller done...
        public List<Company> GetCompanyList()
        {
            return _db.Companies.ToList();
        }

        //controller done..
        public List<Department> GetDeptByCom(int comId)
        {
            List<Department> depList= _db.Departments.Where(c=>c.ComId==comId).ToList();
            return depList;
        }

        //controller done..
        public Department GetDeptById(int id)
        {
            return _db.Departments.Include(c=>c.Company).FirstOrDefault(c=>c.Id==id);
        }

        //controller done..
        public User GetUserByEmail(string email)
        {
            return _db.Users.FirstOrDefault(c=>c.Email==email);
        }

        //controller done..
        public User GetUserById(int id)
        {
            return _db.Users.FirstOrDefault(c => c.Id == id);
        }

        //controller done..
        public List<User> GetUserListByCom(int comId)
        {
            return _db.Users.Where(c=>c.ComId==comId).ToList();
        }

        //contrller done...
        public List<User> GetUserListByDept(int deptId)
        {
            return _db.Users.Where(c => c.DeptId == deptId).ToList();
        }
    }
}
