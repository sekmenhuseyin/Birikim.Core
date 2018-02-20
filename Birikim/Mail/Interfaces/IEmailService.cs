using System.Collections.Generic;

namespace Birikim.Mail
{
    public interface IEmailService
    {
        List<EmailMessage> Receive(int maxCount = 10);

        bool Send(EmailMessage emailMessage);
    }
}