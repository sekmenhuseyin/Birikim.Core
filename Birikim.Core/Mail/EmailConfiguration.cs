namespace Birikim.Mail
{
    public class EmailConfiguration : IEmailConfiguration
    {
        public string ServerName { get; set; }
        public int ServerPort { get; set; }
        public bool ServerSSL { get; set; }
        public string MailUsername { get; set; }
        public string MailPassword { get; set; }
    }
}