using Cli.Mail.Models;

namespace Cli.Mail.Tests.Builders
{
    public class UserBuilder
    {
        private string _username = "MyUsername";
        private string _password = "MyPassword";
        
        public User Build() => 
            new User(_username, _password);
    }
}