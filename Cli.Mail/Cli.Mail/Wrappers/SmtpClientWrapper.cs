using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace Cli.Mail.Wrappers
{
    public class SmtpClientWrapper : ISmtpClientWrapper
    {
        private readonly SmtpClient _client;
        
        public SmtpClientWrapper()
        {
            _client = new SmtpClient();
        }
        
        public void Connect(string serverHost, int serverPort, bool serverUserSsl)
        {
            _client.Connect(serverHost, serverPort, serverUserSsl);
        }

        public void Authenticate(string userName, string password)
        {
            _client.Authenticate(userName, password);
        }

        public void Disconnect(bool quit)
        {
            _client.Disconnect (true);
        }
        
        public async Task SendAsync(MimeMessage message)
        {
            await _client.SendAsync(message);
        }
    }
}