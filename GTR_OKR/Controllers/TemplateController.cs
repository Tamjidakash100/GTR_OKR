using GTR_OKR.DTO;
using GTR_OKR.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTR_OKR.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        private readonly ITemplate _template;
        public TemplateController(ITemplate template)
        {
            _template = template;
        }

        

        [HttpPost]
        public IActionResult CreateTemp(TemplateDTO templateDTO)
        {
            string msg = _template.CreateTemp(templateDTO);
            return Ok(msg);
        }
        [HttpDelete]
        public IActionResult DeleteTemp(TemplateDTO templateDTO)
        {
            string msg = _template.DeleteTemp(templateDTO);
            return Ok(msg);
        }
        [HttpPut]
        public IActionResult EditTemplate(TemplateDTO templateDTO)
        {
            string msg = _template.EditTemp(templateDTO);
            return Ok(msg);
        }
        [HttpGet]
        public IActionResult GetTempByOwner(int ownerId)
        {
            var tempList = _template.GetTempOwner(ownerId);
            return Ok(tempList);
        }
        [HttpGet]
        public IActionResult GetTaskByUser(int? userId)
        {
            if (userId == null)
            {
                return BadRequest();
            }
            var tasks = _template.GetTaskListByUser(userId);
            if (tasks == null)
            {
                return NotFound();
            }
            return Ok(tasks);
        }
        [HttpGet]
        public IActionResult GetTempByUser(int? userId)
        {
            if (userId == null)
            {
                return BadRequest();
            }
            var tasks = _template.GetTempListByUser(userId);
            if (tasks == null)
            {
                return NotFound();
            }
            return Ok(tasks);
        }
    }
}
