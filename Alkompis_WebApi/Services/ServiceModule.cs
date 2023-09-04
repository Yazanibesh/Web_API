using AlkompisApp.Services.AuthServices;

namespace AlkompisApp.Services
{
    public static class ServiceModule
    {
        public static void Register(IServiceCollection Service)
        {
            Service.AddScoped<IAuthService, AuthService>();
        }
    }
}
