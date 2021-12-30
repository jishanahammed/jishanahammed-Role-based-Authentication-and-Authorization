using D_Ui.Models.Domain.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace D_Ui.Service.Extensions
{
    public class CheckUserContextService : ICheckUserContext
    {
        private ApplicationUser _currentUser;
        private UserManager<ApplicationUser> _userManager;
        private HttpContext _httpContext;
        private RoleManager<IdentityRole> _roleManager;
        private SignInManager<ApplicationUser> _signInManager;

        public CheckUserContextService(UserManager<ApplicationUser> userManager,
                          IHttpContextAccessor contextAccessor,
                          RoleManager<IdentityRole> roleManager,
                          SignInManager<ApplicationUser> signInManager
                          )
        {
            _userManager = userManager;
            _httpContext = contextAccessor.HttpContext;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public async Task<ApplicationUser> CurrentLoginUserAsync()
        {
            var contextUser = _httpContext.User;
            if (contextUser != null)
            {

                _currentUser = await _userManager.GetUserAsync(contextUser);
            }

            if (_currentUser != null)
            {
                return _currentUser;
            }
            return _currentUser;
        }

        

        public async Task<bool> IsUserSignedIn()
        {
            var contextUser = _httpContext.User;
            _currentUser = await _userManager.GetUserAsync(contextUser);

            if (_currentUser != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
