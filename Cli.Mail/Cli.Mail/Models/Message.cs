using MimeKit;

namespace Cli.Mail.Models
{
    public class Message
    {
        public string Author { get; }
        public string Recipient { get; }
        public string Subject { get; }
        public string Body { get; }

        public Message(User user, string recipient, string subject, string body)
        {
            Author = user.Username;
            Recipient = recipient;
            Subject = subject;
            Body = body;
        }

        public MimeMessage ToMimeMessage()
        {
            var message = new MimeMessage();
            
            message.From.Add (new MailboxAddress (Author));
            message.To.Add (new MailboxAddress (Recipient));
            message.Subject = Subject;
            message.Body = new TextPart ("plain") {
                Text = Body
            };

            return message;
        }
    }
}