namespace CameraBazaar.Web.Controllers
{
    using CameraBazaar.Services.Contracts;
    using CameraBazaar.Services.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    public class AdminController : Controller
    {
        private readonly IUserService userService;

        public AdminController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult All()
        {
            IEnumerable<UserSellerStatusModel> userSellerStatusModels = userService.GetAllUsersInfo();

            return View(userSellerStatusModels);
        }

        public IActionResult ChangeStatus(string username)
        {
            if (username != null)
            {
                if (this.userService.UserExistsByUsername(username))
                {
                    this.userService.ChangeStatus(username);

                    return RedirectToAction(nameof(All));
                }
            }

            return BadRequest();
        }
    }
}

