using System;
using System.Collections.Generic;
using System.Text;

namespace EmailService.Model
{
    public class EmailOptions
    {
        public EmailProvider Provider { get; set; }
        public GoogleCredentials GoogleCredentials { get; set; }
        public SmtpSettings SmtpSettings { get; set; }
        public OutlookCredentials OutlookCredentials { get; set; }
    }

    public enum EmailProvider
    {
        Google,
        SMTP,
        Outlook
    }
}
