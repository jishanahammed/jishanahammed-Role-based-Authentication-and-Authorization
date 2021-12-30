using D_Ui.Models.Domain.Auth;
using System.Threading.Tasks;

namespace D_Ui.Service.Extensions
{
    public interface ICheckUserContext
    {
        Task<ApplicationUser> CurrentLoginUserAsync();

        Task<bool> IsUserSignedIn();
    }
}
