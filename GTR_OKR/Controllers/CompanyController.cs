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

namespace GTR_OKR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IUserInfo _userInfo;
        public CompanyController(IUserInfo userInfo)
        {
            _userInfo = userInfo;
        }

        [HttpGet]

        public List<Company> Get()
        {
            return _userInfo.GetCompanyList();
        }
        
        [HttpPost]
        public string PostCompany(Company company)
        {
           var msg = _userInfo.CreateCompany(company);
            return msg;
        }

        
    }
}
