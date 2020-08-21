using System.Threading.Tasks;
using MimeKit;

namespace Cli.Mail.Wrappers
{
    public interface ISmtpClientWrapper
    {
        void Connect(string serverHost, int serverPort, bool serverUserSsl);
        void Authenticate(string userName, string password);
        void Disconnect(bool quit);
        Task SendAsync(MimeMessage message);
    }
}