using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string emailTo, string subject, string body);
        Task SendEmailAsync(string fromEmail,string emailTo, string subject, string body);
    }
}
