using Cli.Mail.Models;

namespace Cli.Mail.Tests.Builders
{
    public class MailOptionsBuilder
    {
        private string _username = "jack@mail.com";
        private string _password = "P@ssword1234";
        private string _recipient = "black@mail.com";
        private string _subject = "Greetings";
        private string _message = "How are you doing?";

        public MailOptions Build()
        {
            return new MailOptions()
            {
                Username = _username,
                Password = _password,
                Recipient = _recipient,
                Subject = _subject,
                Message = _message
            };
        }
    }
}