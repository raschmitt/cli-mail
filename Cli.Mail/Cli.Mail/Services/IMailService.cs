using System.Threading.Tasks;

namespace Cli.Mail.Services
{
    public interface IMailService
    {
        Task Send();
    }
}