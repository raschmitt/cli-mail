
# Cli.Mail <img src="https://i.imgur.com/V9XHUfD.png" align='right' />

[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/raschmitt/cli-mail/.NET%20Core%20-%20Build%20&%20Test?label=Build%20%26%20Test&style=flat-square)](https://github.com/raschmitt/cli-mail/actions?query=workflow%3A%22.NET+Core+-+Build+%26+Test%22)
[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/raschmitt/cli-mail/Nuget%20Deploy?label=Deploy&style=flat-square)](https://github.com/raschmitt/cli-mail/actions?query=workflow%3A%22Nuget+Deploy%22)
[![Nuget](https://img.shields.io/nuget/v/CliMail?label=Nuget&style=flat-square)](https://www.nuget.org/packages/CliMail/)
[![Nuget](https://img.shields.io/nuget/dt/CliMail?color=Blue&label=Downloads&style=flat-square)](https://www.nuget.org/stats/packages/CliMail?groupby=Version)

Cli.Mail is an easy to use .Net CLI tool for sending emails.

To be continued...

## Install

`dotnet tool install -g climail`

## How to use

### Sample

`climail -username mark@gmail.com -password P@assword1234 -recipient jack@outlook.com.br -subject "Regards" -message "Hey Jack, how Are you doing"`

### Parameters

| Parameter | Description | Required |
| --- | --- | --- |
| -u, --username | Email from where the message will be sent | Yes |
| -p, --password | Email account password | Yes |
| -r, --recipient  | Email recipient | Yes |
| -s, --subject  | Email recipient | Yes |
| -m, --message     | Email message | Yes |
| --help     | Display the help screen | No |
| --version     | Displays version information | No |

## Constributions

  Contributions and feature requests are always welcome.
