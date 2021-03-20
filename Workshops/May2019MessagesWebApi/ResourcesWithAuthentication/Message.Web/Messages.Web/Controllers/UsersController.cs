using Messages.Data;
using Messages.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Messages.Web.Controllers
{
    public class UsersController : BaseController
    {
        private readonly MessagesContext context;

        public UsersController(MessagesContext context)
        {
            this.context = context;
        }

        [HttpPost(Name = "Register")]
        [Route("register")]
        public async Task<ActionResult> Register(UserCreateBindingModel userCreateBindingModel)
        {
            var user = await this.context.Users
                .SingleOrDefaultAsync(u => u.UserName == userCreateBindingModel.UserName);

            if (user != null)
            {
                return this.BadRequest();
            }

            var newUser = new User
            {
                UserName = userCreateBindingModel.UserName,
                Password = userCreateBindingModel.Password
            };

            await this.context.Users.AddAsync(newUser);
            await this.context.SaveChangesAsync();

            return this.Ok(userCreateBindingModel);
        }
    }
}
