using AlkompisApp.Dtos.Auth;
using AlkompisApp.Services.AuthServices;
using Microsoft.AspNetCore.Mvc;
namespace AlkompisApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            var result = await _authService.Login(model);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            var result = await _authService.Register(model);
            return Ok(new { message = "User Register Successfully" });
        }
    }
}
