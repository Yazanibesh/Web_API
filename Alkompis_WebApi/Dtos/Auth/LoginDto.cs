using System.ComponentModel.DataAnnotations;

namespace AlkompisApp.Dtos.Auth
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
