using OnlineMedicineStore.Models;
using System.Threading.Tasks;

namespace OnlineMedicineStore.Service
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmailOptions userEmailOptions);
        Task SendEmailForForgotPassword(UserEmailOptions userEmailOptions);
    }
}