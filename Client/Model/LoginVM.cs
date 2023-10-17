
namespace Client.Model
{
    public class LoginVM
    {
        public string Token { get; set; }
        public string expiresIn { get; set; }
        public User user { get; set; }
    }
}
