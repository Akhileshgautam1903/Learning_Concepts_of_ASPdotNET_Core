using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Learning_Concepts_of_ASPdotNET_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("login")]
        public IActionResult Login(string username, string password)
        {
            if (username != "admin" || password != "password")
                return Unauthorized();

            //claims is an array of Claim objects that represent the user's identity and roles.
            //These claims will be included in the JWT payload and can be used for authorization purposes when the token is validated in subsequent requests.
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var jwtSettings = _config.GetSection("JwtSettings");

            //Encoding.UTF8.GetBytes converts the secret string into a byte array, which is required for creating the SymmetricSecurityKey used in signing the JWT
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]));

            //creds is an instance of SigningCredentials that specifies the key and the algorithm (HMAC SHA256) used to sign the JWT,
            //ensuring that the token can be verified and trusted by the server when it is received in subsequent requests
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // The JwtSecurityToken constructor creates a new JWT token with the specified issuer, audience, claims, expiration time, and signing credentials.
            var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(double.Parse(jwtSettings["DurationInMinutes"])),
                signingCredentials: creds
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new { token = jwt });
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // JWT is stateless → no server logout
            return Ok("Logout successful (delete token on client)");
        }
    }
}
