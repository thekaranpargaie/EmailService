using System.Net.Mail;
using System.Threading.Tasks;

namespace EmailService
{
    public interface IEmailProvider
    {
        Task SendAsync(MailMessage message);
    }
}
