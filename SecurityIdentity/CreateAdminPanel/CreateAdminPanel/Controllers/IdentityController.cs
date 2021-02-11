namespace CreateAdminPanel.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    using CreateAdminPanel.Data;
    using CreateAdminPanel.Models.Identity;
    using CreateAdminPanel.Models;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;

    public class IdentityController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<User> userManager;

        public IdentityController(
            ApplicationDbContext db,
            UserManager<User> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }

        [Authorize(Roles = GlobalConstants.AdminRoleName)]
        public IActionResult All()
        {
            var users = this.db
                .Users
                .OrderBy(u => u.Email)
                .Select(u => new ListUserViewModel
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    Email = u.Email,
                })
                .ToList();

            return this.View(users);
        }

        public async Task<IActionResult> UserRoles(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);
            if(user == null)
            {
                return this.NotFound();
            }

            var userRoles = await this.userManager.GetRolesAsync(user);
            var viewModelResults = new ListUserRolesViewModel()
            {
                UserId = user.Id,
                Email = user.Email,
                Roles = userRoles
            };

            return this.View(viewModelResults);
        }
    }
}
