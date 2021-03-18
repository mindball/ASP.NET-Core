using ConfigureJWTokenWithCredentials.Data;
using ConfigureJWTokenWithCredentials.Infrastructure;
using ConfigureJWTokenWithCredentials.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConfigureJWTokenWithCredentials.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        
        private UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly ApplicationDbContext context;
        private IOptions<JwtSettings> jwtSettings;
        //private readonly JwtSettings jwtSettings;


        public UsersController(//IUserService userService,
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ApplicationDbContext context,
            IOptions<JwtSettings> jwtSettings
            )
        {
            //this.userService = userService;
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.jwtSettings = jwtSettings;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Login([FromBody] LoginUserBindingModel loginUser)
        {
            var result = await this.signInManager.PasswordSignInAsync(loginUser.UserName, loginUser.Password, true, lockoutOnFailure: false);

            if (!result.Succeeded) return this.BadRequest();

            var user = await this.userManager.FindByNameAsync(loginUser.UserName);

            //var user = await this.userManager.GetUserAsync(this.User);

            var tokenHandler = new JwtSecurityTokenHandler();
            var secret = this.jwtSettings.Value.Secret;

            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(
                                 new SymmetricSecurityKey(key),
                                 SecurityAlgorithms.HmacSha256Signature
            )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var userToken = tokenHandler.WriteToken(token);

            return userToken;                       
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            //after authentication username is list
            var user = this.User.Identity.Name;

            return "username: " + user;
        }
    }
}
