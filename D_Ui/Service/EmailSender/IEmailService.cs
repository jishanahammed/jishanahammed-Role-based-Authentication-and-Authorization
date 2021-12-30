using System.Threading.Tasks;

namespace D_Ui.Service.EmailSender
{
    public interface IEmailService
    {
        Task SendEmailAsync(MaileRequst maileRequst);
    }
}
