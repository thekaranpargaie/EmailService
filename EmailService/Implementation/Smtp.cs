using EmailService.Model;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmailService.Implementation
{
    public class Smtp : IEmailProvider
    {
        private readonly EmailOptions _emailOptions;
        public Smtp(EmailOptions emailOptions)
        {
            _emailOptions = emailOptions;
        }
        public async Task SendAsync(MailMessage message)
        {
            using (var smtpClient = new SmtpClient(_emailOptions.SmtpSettings.Host, _emailOptions.SmtpSettings.Port))
            {
                smtpClient.Credentials = new NetworkCredential(_emailOptions.SmtpSettings.Username, _emailOptions.SmtpSettings.Password);
                smtpClient.EnableSsl = true;

                await smtpClient.SendMailAsync(message);
            }
        }
    }
}
