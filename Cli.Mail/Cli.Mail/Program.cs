using System;
using System.Collections.Generic;
using Cli.Mail.Models;
using Cli.Mail.Services;
using CommandLine;

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
                var mailService = new MailService(options);

                mailService.Send().Wait();
            }
            
            static void HandleParseError(IEnumerable<Error> errors)
            {
                Console.WriteLine("Sorry something went wrong...");
            }
        }
    }
}