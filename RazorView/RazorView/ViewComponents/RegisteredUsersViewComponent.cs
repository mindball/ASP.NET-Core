using RazorView.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RazorView.ViewModels.ViewComponents;

namespace RazorView.ViewComponents
{
    public class RegisteredUsersViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;

        public RegisteredUsersViewComponent(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IViewComponentResult Invoke(string title)
        {
            var users = this.dbContext.Users.Count();
            var viewModel = new RegisteredUsersViewModel
            {
                Title = title,
                Users = users,
            };

            return this.View(viewModel);
        }
    }
}
