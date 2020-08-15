namespace Cli.Mail.Models
{
    public static class Server
    {
        public static string Host => "smtp.gmail.com";
        public static int Port => 587;
        public static bool UseSsl => false;
    }
}