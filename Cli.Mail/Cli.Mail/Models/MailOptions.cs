using CommandLine;

namespace Cli.Mail.Models
{
    public class MailOptions
    {
        [Option('u', "username", Required = true, HelpText = "Email from where the message will be sent.")]
        public string Username { get; set; }
        [Option('p', "password", Required = true, HelpText = "Email account password.")]
        public string Password { get; set; }
        [Option('r', "recipient", Required = true, HelpText = "Email recipient.")]
        public string Recipient { get; set; }
        [Option('s', "subject", Required = true, HelpText = "Email subject.")]
        public string Subject { get; set; }
        [Option('m', "message", Required = true, HelpText = "Email message.")]
        public string Message { get; set; }
    }
}