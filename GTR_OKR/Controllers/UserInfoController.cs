using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GTR_OKR.Context;
using GTR_OKR.Models;
using GTR_OKR.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace GTR_OKR.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors]
    public class UserInfoController : ControllerBase
    {
        private readonly IUserInfo _userInfo;
        public UserInfoController(IUserInfo userInfo)
        {
            _userInfo = userInfo;
        }

        [HttpGet]

        public List<Company> Get()
        {
            return _userInfo.GetCompanyList();
        }

        [HttpPost]
        public IActionResult PostCompany(Company company)
        {
            var msg = _userInfo.CreateCompany(company);
            return Ok(msg);
        }

        [HttpPut]
        public IActionResult PutCompany(Company company)
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
         public IActionResult CreateDept([FromBody]Department department)
        {
            return Ok(_userInfo.CreateDept(department));
        }
    }
}
