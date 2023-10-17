

namespace DataAccess.Model
{
    public class Login
    {
        public  string Token { get; set; }
        public string expiresIn { get; set; }
        public User user { get; set; }
    }
}
