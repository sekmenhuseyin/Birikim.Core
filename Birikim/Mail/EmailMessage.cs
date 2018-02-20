using System.Collections.Generic;

namespace Birikim.Mail
{
    public class EmailMessage
    {
        public EmailMessage()
        {
            ToAddresses = new List<EmailAddress>();
            FromAddresses = new List<EmailAddress>();
        }

        public string Content { get; set; }
        public List<EmailAddress> FromAddresses { get; set; }
        public string Subject { get; set; }
        public List<EmailAddress> ToAddresses { get; set; }
    }
}