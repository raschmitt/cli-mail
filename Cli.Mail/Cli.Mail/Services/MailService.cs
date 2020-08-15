using System;
using System.Threading.Tasks;
using Cli.Mail.Models;
using MailKit.Net.Smtp;
using MimeKit;

namespace Cli.Mail.Services
{
    public class MailService : IMailService, IDisposable
    {
        private readonly SmtpClient _client;
        private readonly MimeMessage _message;
        
        public MailService(MailOptions mailOptions)
        {
            _client = new SmtpClient();
            _message = new MimeMessage();
            
            _client.Connect(Server.Host, Server.Port, Server.UseSsl);
            _client.Authenticate(mailOptions.Username, mailOptions.Password);
            
            MapMessage(mailOptions);
        }
        
        public async Task Send()
        {
            await _client.SendAsync(_message);
        }

        public void Dispose()
        {
            _client.Disconnect (true);
        }

        private void MapMessage(MailOptions mailOptions)
        {
            _message.From.Add (new MailboxAddress (mailOptions.Username));
            _message.To.Add (new MailboxAddress (mailOptions.Recipient));
            _message.Subject = mailOptions.Subject;
            _message.Body = new TextPart ("plain") {
                Text = mailOptions.Message
            };
        }
    }
}