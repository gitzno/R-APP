using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_GATE.Controllers.Admin
{
    [Route("api/superUser")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello Super user");
        }
    }
}
