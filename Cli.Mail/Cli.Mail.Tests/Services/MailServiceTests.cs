using Cli.Mail.Models;
using Cli.Mail.Services;
using Cli.Mail.Tests.Builders;
using Cli.Mail.Wrappers;
using MimeKit;
using NSubstitute;
using Xunit;

namespace Cli.Mail.Tests.Services
{
    public class MailServiceTests
    {
        private readonly ISmtpClientWrapper _client;
        private readonly MailOptions _options;

        public MailServiceTests()
        {
            _client = Substitute.For<ISmtpClientWrapper>();
            _options = new MailOptionsBuilder().Build();
        }
        
        [Fact]
        public void Should_create_new_mail_service_instance()
        {
            //Arrange
            var username = _options.Username;
            var password = _options.Password;
                
            //Act
            new MailService(_options, _client);

            //Assert
            _client.Received(1).Connect(Server.Host, Server.Port, Server.UseSsl);
            _client.Received(1).Authenticate(username, password);
        }
        
        [Fact]
        public void Should_send_email()
        {
            //Arrange
            var mailService = new MailService(_options, _client);
            
            //Act
            mailService.Send();

            //Assert
            _client.Received(1).SendAsync(Arg.Any<MimeMessage>());
            _client.Received(1).Disconnect(true);
        }
    }
}