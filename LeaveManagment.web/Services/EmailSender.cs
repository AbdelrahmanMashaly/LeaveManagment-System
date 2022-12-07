using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagment.web.Services
{
    public class EmailSender : IEmailSender
    {
        private string smtpserver;
        private int smtpport;
        private string fromEmailAddress;

        public EmailSender(string smtpserver, int smtpport, string fromEmailAddress)
        {
            this.smtpserver = smtpserver;
            this.smtpport = smtpport;
            this.fromEmailAddress = fromEmailAddress;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var Message = new MailMessage
            {
                From = new MailAddress(fromEmailAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            Message.To.Add(new MailAddress(email));

            using (var client = new SmtpClient(smtpserver,smtpport))
            {
                client.Send(Message);
            }
            return Task.CompletedTask;
        }
    }
}
