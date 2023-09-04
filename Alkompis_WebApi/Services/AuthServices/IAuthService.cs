using AlkompisApp.Dtos.Auth;

namespace AlkompisApp.Services.AuthServices
{
    public interface IAuthService
    {
        Task<LoginResultDto> Login(LoginDto model);
        Task<bool> Register(RegisterDto model);
        Task<bool> Logout();
    }
}
