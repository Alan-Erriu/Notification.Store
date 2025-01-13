using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Store.Configuration.EmailConfiguration
{
    public class GmailConfig
    {
        public string? SMTP { get; set; }
        public string? MailAddress { get; set; }
        public string? APPCredential { get; set; }
    }
}
