using LearningSystem.Data.Models;
using LearningSystem.Services.Admin;
using LearningSystem.Web.Areas.Admin.Models.Courses;
using LearningSystem.Web.Areas.Admin.Models.Users;
using LearningSystem.Web.Controllers;
using LearningSystem.Web.Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Web.Areas.Admin.Controllers
{
    public class UsersController : BaseAdminController
    {
        private readonly IAdminUserService userService;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UsersController(IAdminUserService userService,
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.userService = userService;

            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await this.userService.AllAsync();
            var roles = await this.roleManager
                .Roles
                .Select(r => new SelectListItem
                {
                    Text = r.Name,
                    Value = r.Name
                })
                .ToListAsync();

            return View(new UserListingViewModel
            {
                Users = users,
                Roles = roles
            });
        }

        public async Task<IActionResult> AddToRole(AddUserToRoleFormModel userForm)
        {
            var user = await this.userManager.FindByIdAsync(userForm.UserId);
            var role = await this.roleManager.FindByNameAsync(userForm.Role);

            var userExist = user != null;
            var roleExist = role != null;

            if (!userExist || !roleExist)
            {
                ModelState.AddModelError(string.Empty, "Invalid identity details");
            }

            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            await this.userManager.AddToRoleAsync(user, userForm.Role);

            TempData.AddSuccessMessage($"User {user.UserName} successfully added to the {userForm.Role} role.");

            return this.RedirectToAction(nameof(Index));
        }
    }
}
