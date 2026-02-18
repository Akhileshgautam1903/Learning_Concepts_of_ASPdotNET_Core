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

        //Since we have specified login path while registering cookie so when the user is not authorized
        //server makes a get request to /api/auth/login but we only have post req setup for that route
        //it's basically for MVC 
        //For api we can set options while registering cookieAuthentication
    }
}
