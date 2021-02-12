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
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class IdentityController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public IdentityController(
            ApplicationDbContext db,
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.roleManager = roleManager;
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

        public IActionResult Register()
            => this.View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var result = await this.userManager.CreateAsync(new User
            {
                Email = model.Email,
                UserName = model.Email
            }, model.Password);

            if (result.Succeeded)
            {
                //SuccessMessage може да се изнесе като extension method или базов контролер
                this.TempData["SuccessMessage"] = $"Created user: {model.Email}";
                return this.RedirectToAction(nameof(All));
            }

            this.AddModelError(result);

            return this.View(model);
        }

        public async Task<IActionResult> ChangePassword(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);
            if (user == null)
            {
                return this.NotFound();
            }

           

            return this.View(
                nameof(IdentityChangePasswordViewModel),
                new IdentityChangePasswordViewModel
                {
                    UserName = user.Email                    
                });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(string id, 
            IdentityChangePasswordViewModel model)
        {
            if(!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var user = await this.userManager.FindByIdAsync(id);
            if (user == null)
            {
                return this.NotFound();
            }
            var token = await this.userManager.GeneratePasswordResetTokenAsync(user);
            var result = await this.userManager.ResetPasswordAsync(user, token, model.Password);

            if(result.Succeeded)
            {
                //SuccessMessage може да се изнесе като extension method или базов контролер
                this.TempData["SuccessMessage"] = $"Password changed for user: {user.Email}";
                return this.RedirectToAction(nameof(All));
            }

            this.AddModelError(result);

            return this.View(nameof(IdentityChangePasswordViewModel), model);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);
            if (user == null)
            {
                return this.NotFound();
            }

            return this.View(new DeleteUserViewModel
            {
                UserId = user.Id,
                UserName = user.UserName
            });
        }

        public async Task<IActionResult> Destroy(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);
            if (user == null)
            {
                return this.NotFound();
            }

            await this.userManager.DeleteAsync(user);

            return this.RedirectToAction(nameof(All));
        }


        public async Task<IActionResult> AddRole(string id)
        {
            var rolesSelectItems = this.roleManager
                .Roles
                .Select(r => new SelectListItem
                {
                    Text = r.Name,
                    Value = r.Name
                })
                .ToList();

            return this.View(rolesSelectItems);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRole(string id, string role)
        {
            var user = await this.userManager.FindByIdAsync(id);
            var roleName = await this.roleManager.FindByNameAsync(role);

            if (user == null || roleName == null)
            {
                return this.NotFound();
            }

            var result = await this.userManager.AddToRoleAsync(user, roleName.Name);
            if(!result.Succeeded)
            {
                AddModelError(result);
                return BadRequest(this.ModelState);
            }

            this.SetTempDataMsg(GlobalConstants.SuccessMsg,
                     $"User {user.UserName} added to {roleName.Name} role!");

            return this.RedirectToAction(nameof(All));           
        }

        private void SetTempDataMsg(string statusMsg, string msg)
        {
            this.TempData[statusMsg] = msg;
        }

        private void AddModelError(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                this.ModelState.AddModelError(string.Empty, error.Description);
            }
        }
    }
}
