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

        //// GET: api/Company/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Company>> GetCompany(int id)
        //{
        //  if (_context.Companies == null)
        //  {
        //      return NotFound();
        //  }
        //    var company = await _context.Companies.FindAsync(id);

        //    if (company == null)
        //    {
        //        return NotFound();
        //    }

        //    return company;
        //}

        //// PUT: api/Company/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCompany(int id, Company company)
        //{
        //    if (id != company.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(company).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CompanyExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Company
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public string PostCompany(Company company)
        {
           var msg = _userInfo.CreateCompany(company);
            return msg;
        }

        // DELETE: api/Company/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCompany(int id)
        //{
        //    if (_context.Companies == null)
        //    {
        //        return NotFound();
        //    }
        //    var company = await _context.Companies.FindAsync(id);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Companies.Remove(company);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool CompanyExists(int id)
        //{
        //    return (_context.Companies?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
