using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRAApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        public EmpController()
        {
                
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
