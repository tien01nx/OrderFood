namespace Client.DTO
{
    public class LoginDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"UserName: {UserName}, Password: [Hidden]";
        }
    }
}
