using Messages.Data;
using Messages.Web.Infrastructure;
using Messages.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Messages.Web.Controllers
{
    public class UsersController : BaseController
    {
        private readonly MessagesContext context;
        private IOptions<JwtSettings> jwtSettings;

        public UsersController(MessagesContext context, 
            IOptions<JwtSettings> jwtSettings)
        {
            this.context = context;
            this.jwtSettings = jwtSettings;
        }

        [HttpPost(Name = "Register")]
        [Route("register")]
        public async Task<ActionResult> Register(UserBindingModel userCreateBindingModel)
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

        [HttpPost(Name = "Login")]
        [Route("login")]
        public async Task<ActionResult> Login([FromBody]UserBindingModel userCreateBindingModel)
        {
            var user = await this.context.Users
                .SingleOrDefaultAsync(u => u.UserName == userCreateBindingModel.UserName && u.Password == userCreateBindingModel.Password);

            if (user == null)
            {
                return this.BadRequest();
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(jwtSettings.Value.Secret);

            var tokenDescripton = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UserName)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                    )
            };                      

            var token = tokenHandler.CreateToken(tokenDescripton);
            //from java script file split token
            /* 
               let token = data.rawHeader + 
                '.' +
                data.rawPayload +
                '.' +
                data.rawSignature;
            */

            return Ok(token);

            //var splittedToken = tokenHandler.WriteToken(token);

            //return Ok(splittedToken);

        }

        [HttpGet("[action]")]        
        public ActionResult<string> GetUserName()
        {
            return this.User.Identity.Name;
        }
    }
}
