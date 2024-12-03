using EmailService.Implementation;
using EmailService.Model;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    public class EmailService
    {
        private readonly IEmailProvider _emailProvider;

        public EmailService(EmailOptions emailOptions)
        {
            switch (emailOptions.Provider)
            {
                case EmailProvider.SMTP:
                    _emailProvider = new Smtp(emailOptions);
                    break;
            }

        }

        public Task SendAsync(MailMessage message)
        {
            return _emailProvider.SendAsync(message);
        }
    }
}
