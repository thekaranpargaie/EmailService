﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmailService.Model
{
    public class SmtpSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
