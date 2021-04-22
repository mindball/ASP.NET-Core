using LearningSystem.Data.Models;
using LearningSystem.Services.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LearningSystem.Web.Controllers
{  
    public class UsersController : Controller
    {
        private readonly IUsersService users;
        private readonly UserManager<User> userManager;

        public UsersController(
           IUsersService users,
           UserManager<User> userManager)
        {
            this.users = users;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Profile(string username)
        {
            var user = await this.userManager.FindByNameAsync(username);

            if (user == null)
            {
                return NotFound();
            }

            var profile = await this.users.ProfileAsync(user.Id);

            return View(profile);
        }

        public async Task<IActionResult>  DownloadCertificate([FromRoute(Name = "id")]string courseId)
        {
            var userId = this.userManager.GetUserId(User);
            var certificateContent = await this.users
                .GetPdfCertificate(courseId, userId);

            if (certificateContent == null)
            {
                return BadRequest();
            }

            return File(certificateContent, "application/pdf", "Certificate.pdf");
        }

    }
}
