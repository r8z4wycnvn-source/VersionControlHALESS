using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VersionControlHALES.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyNameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMyName()
        {
            var data = new { Name = "Jimeir Hales" };
            return new JsonResult(data);
        }
    }
}
