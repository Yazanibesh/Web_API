namespace AlkompisApp.Dtos.Auth
{
    public class LoginResultDto
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string AccessToken { get; set; }
        public DateTime Expiration { get; set; }
    }
}
