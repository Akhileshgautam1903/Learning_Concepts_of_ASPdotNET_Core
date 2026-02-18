using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Learning_Concepts_of_ASPdotNET_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecureController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetSecret()
        {
            return Ok("You accessed protected route using COOKIE auth!");
        }
    }
}
