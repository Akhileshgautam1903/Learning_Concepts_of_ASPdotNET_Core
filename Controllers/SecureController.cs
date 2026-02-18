using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Learning_Concepts_of_ASPdotNET_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecureController : ControllerBase
    {
        [Authorize]     //Authorize attribute ensures that only authenticated users with a valid JWT can access this endpoint
        [HttpGet("data")]
        public IActionResult GetSecureData()
        {
            return Ok("This is protected data accessible only with a valid JWT.");
        }
    }
}
