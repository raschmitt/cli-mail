using System;
using System.Collections.Generic;
using Cli.Mail.Models;
using Cli.Mail.Services;
using Cli.Mail.Wrappers;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;

namespace Cli.Mail
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<MailOptions>(args)
                .WithParsed(RunOptions)
                .WithNotParsed(HandleParseError);
        
            static void RunOptions(MailOptions options)
            { 
                var serviceProvider = new ServiceCollection()
                    .AddSingleton<ISmtpClientWrapper, SmtpClientWrapper>()
                    .BuildServiceProvider();

                var client = serviceProvider.GetService<ISmtpClientWrapper>();
                
                var mailService = new MailService(options, client);

                mailService.Send().Wait();
            }
            
            static void HandleParseError(IEnumerable<Error> errors)
            {
                Console.WriteLine("Sorry something went wrong...");
            }
        }
    }
}