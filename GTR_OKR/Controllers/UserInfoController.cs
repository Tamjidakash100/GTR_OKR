using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GTR_OKR.Context;
using GTR_OKR.DTO;
using GTR_OKR.Interfaces;
using Microsoft.AspNetCore.Cors;
using GTR_OKR.Models;
using AutoMapper;

namespace GTR_OKR.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IUserInfo _userInfo;
        private readonly IMapper _mapper;

        public UserInfoController(IUserInfo userInfo, IMapper mapper)
        {
            _userInfo = userInfo;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult GetCompList()
        {
            return Ok(_userInfo.GetCompanyList());
        }

        [HttpPost]
        public IActionResult PostCompany([FromBody]Company company)
        {
            var msg = _userInfo.CreateCompany(company);
            return Ok(msg);
        }

        [HttpPut]
        public IActionResult PutCompany(CompanyDTO company)
        {
            return Ok(_userInfo.EditCompany(company));
        }

        [HttpGet]
        public IActionResult GetCompanyByEmail(string email) 
        {
            var comp = _userInfo.GetCompanyByEmail(email);

          if(comp != null) 
            {
                return Ok(comp);
            }
              return NotFound();
        }

        [HttpPost]
         public IActionResult CreateDept([FromBody]DepartmentDTO department)
        {
            return Ok(_userInfo.CreateDept(department));
        }
        [HttpGet]
        public IActionResult GetDeptByCom(int comId)
        {
            var deptList = _userInfo.GetDeptByCom(comId);
            return Ok(deptList);
        }

        [HttpGet]
        public IActionResult GetDeptById(int id) 
        {
            return Ok(_userInfo.GetDeptById(id));   
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody]UserDTO user)
        {
            return Ok(_userInfo.CreateUser(user));
        }

        [HttpGet]
        public IActionResult GetUserById(int id)
        {
            return Ok(_userInfo.GetUserById(id));
        }

        [HttpGet]
        public IActionResult GetUserByEmail(string email) 
        {
            return Ok(_userInfo.GetUserByEmail(email)); 
        }

        [HttpGet]

        public IActionResult GetUserByComId(int comId)
        {
            return Ok(_userInfo.GetUserListByCom(comId));
        }

        [HttpGet]
        public IActionResult GetUserByDept(int deptId)
        {
            return Ok(_userInfo.GetUserListByDept(deptId)); 
        }
        [HttpGet]
        public IActionResult GetUserByTask(int? taskId)
        {
            if (taskId == null)
            {
                return BadRequest();
            }
            var users = _userInfo.GetUserListByTask(taskId);
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }
        [HttpGet]
        public IActionResult GetUserByTemp(int? tempId)
        {
            if (tempId == null)
            {
                return BadRequest();
            }
            var users = _userInfo.GetUserListByTemp(tempId);
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }
    }
}
