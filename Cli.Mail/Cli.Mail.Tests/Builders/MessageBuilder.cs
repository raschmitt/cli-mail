using Cli.Mail.Models;

namespace Cli.Mail.Tests.Builders
{
    public class MessageBuilder
    {
        private User _user = new UserBuilder().Build();
        private string _recipient = "jack@mail.com";
        private string _subject = "Greetings";
        private string _body = "Hey Jack, How are tou doing?";
        
        public Message Build() =>
            new Message(_user, _recipient, _subject, _body);
    }
}