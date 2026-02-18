using Microsoft.AspNetCore.Mvc;

namespace Learning_Concepts_of_ASPdotNET_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecureControllercs: ControllerBase
    {
        [HttpGet]
        public IActionResult Secret()
        {
            return Ok("You accessed protected route using COOKIE Auth");
        }
    }
}
