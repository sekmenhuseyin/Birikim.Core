using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Birikim.Mail
{
    public class EmailService : IEmailService
    {
        private readonly IEmailConfiguration _emailConfiguration;

        /// <summary>
        /// Constructor to get email server settings
        /// </summary>
        /// <param name="emailConfiguration"></param>
        public EmailService(IEmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }

        /// <summary>
        /// Email Receiver
        /// </summary>
        /// <param name="maxCount"></param>
        /// <returns></returns>
        public List<EmailMessage> Receive(int maxCount = 10)
        {
            using (var emailClient = new Pop3Client())
            {
                emailClient.Connect(_emailConfiguration.ServerName, _emailConfiguration.ServerPort, true);

                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

                emailClient.Authenticate(_emailConfiguration.MailUsername, _emailConfiguration.MailPassword);

                List<EmailMessage> emails = new List<EmailMessage>();
                try
                {
                    for (int i = 0; i < emailClient.Count && i < maxCount; i++)
                    {
                        var message = emailClient.GetMessage(i);
                        var emailMessage = new EmailMessage
                        {
                            Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody : message.TextBody,
                            Subject = message.Subject
                        };
                        emailMessage.ToAddresses.AddRange(message.To.Select(x => (MailboxAddress)x).Select(x => new EmailAddress { Address = x.Address, Name = x.Name }));
                        emailMessage.FromAddresses.AddRange(message.From.Select(x => (MailboxAddress)x).Select(x => new EmailAddress { Address = x.Address, Name = x.Name }));
                    }
                }
                catch (Exception)
                {
                }

                return emails;
            }
        }

        /// <summary>
        /// email sender
        /// </summary>
        /// <param name="emailMessage"></param>
        public bool Send(EmailMessage emailMessage)
        {
            var message = new MimeMessage();
            message.To.AddRange(emailMessage.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
            message.From.AddRange(emailMessage.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));

            message.Subject = emailMessage.Subject;
            //We will say we are sending HTML. But there are options for plaintext etc.
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = emailMessage.Content
            };

            try
            {
                //Be careful that the SmtpClient class is the one from Mailkit not the framework!
                using (var emailClient = new SmtpClient())
                {
                    //The last parameter here is to use SSL (Which you should!)
                    emailClient.Connect(_emailConfiguration.ServerName, _emailConfiguration.ServerPort, _emailConfiguration.ServerSSL);

                    //Remove any OAuth functionality as we won't be using it.
                    emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

                    emailClient.Authenticate(_emailConfiguration.MailUsername, _emailConfiguration.MailPassword);

                    emailClient.Send(message);

                    emailClient.Disconnect(true);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}