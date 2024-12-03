﻿using System.Net.Mail;
using System.Threading.Tasks;

namespace EmailService
{
    public interface IEmailService
    {
        Task SendAsync(MailMessage message);
    }
}
