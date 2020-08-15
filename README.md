
# Cli.Mail <img src="https://i.imgur.com/V9XHUfD.png" align='right' />

[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/raschmitt/cli-mail/.NET%20Core%20-%20Build%20&%20Test?label=Build%20%26%20Test&style=flat-square)](https://github.com/raschmitt/cli-mail/actions?query=workflow%3A%22.NET+Core+-+Build+%26+Test%22)
[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/raschmitt/cli-mail/Nuget%20Deploy?label=Deploy&style=flat-square)](https://github.com/raschmitt/cli-mail/actions?query=workflow%3A%22Nuget+Deploy%22)
[![Nuget](https://img.shields.io/nuget/v/CliMail?label=Nuget&style=flat-square)](https://www.nuget.org/packages/CliMail/)
[![Nuget](https://img.shields.io/nuget/dt/CliMail?color=Blue&label=Downloads&style=flat-square)](https://www.nuget.org/stats/packages/CliMail?groupby=Version)

Cli.Mail is an easy to use .Net CLI tool for sending emails.

## Install

```
dotnet tool install -g climail
```

## How to use

Currently Cli.Mail only works for sending emails from gmail accounts, and you have to enable access form less secure apps for it to work properly.

### Enabling less secure apps in gmail

1. Go to your ([Google Account](https://myaccount.google.com/)).
2. On the left navigation panel, click `Security`.
3. On the bottom of the page, in the Less secure app access section, click on `Turn on access` and turn it on.

### Sample usage

```
climail -u mark@gmail.com -p P@assword123 -r jack@icloud.com -s "Regards" -m "Hi Jack, how are you doing?"
```

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
