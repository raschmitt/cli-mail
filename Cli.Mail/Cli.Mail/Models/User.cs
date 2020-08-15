namespace Cli.Mail.Models
{
    public class User
    {
        public string Password { get; } 
        public string Username { get; }

        public User(string username, string password)
        {
            Password = password;
            Username = username;
        }
    }
}