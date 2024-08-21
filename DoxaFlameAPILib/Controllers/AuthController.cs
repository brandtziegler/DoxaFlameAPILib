using DoxaFlameAPILib.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoxaFlameAPILib.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            // For demo purposes, we assume the user is authenticated successfully
            // In a real application, you would validate the user's credentials here
            if (login.Username == "testuser" && login.Password == "password")
            {
                var token = _tokenService.GenerateToken(login.Username);

                return Ok(new { Token = token });
            }

            return Unauthorized();
        }
    }

    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
