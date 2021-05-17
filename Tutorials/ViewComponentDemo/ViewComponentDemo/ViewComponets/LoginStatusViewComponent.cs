using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ViewComponentDemo.ViewComponets
{
    public class LoginStatusViewComponent : ViewComponent
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public LoginStatusViewComponent(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (_signInManager.IsSignedIn(HttpContext.User))
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                return View("LoggedIn", user);
            }
            else
            {
                return View();
            }
        }
    }
}
