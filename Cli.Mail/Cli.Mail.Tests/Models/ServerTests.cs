using Cli.Mail.Models;
using FluentAssertions;
using Xunit;

namespace Cli.Mail.Tests.Models
{
    public class ServerTest
    {
        [Fact]
        public void Should_assert_server_has_properties()
        {
            //Assert
            Server.Host.Should().NotBe(default);
            Server.Port.Should().NotBe(default);
        }
    }
}