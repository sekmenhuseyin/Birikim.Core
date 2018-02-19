namespace Birikim.Mail
{
    public interface IEmailConfiguration
    {
        string ServerName { get; }
        int ServerPort { get; }
        bool ServerSSL { get; }
        string MailUsername { get; set; }
        string MailPassword { get; set; }
    }
}