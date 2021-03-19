using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CreateAndUseInMemoryDB.Filters.AuthorizationFilters
{
    public class RoleFilterAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        //private readonly UserManager<IdentityUser> userManager;

        //public RoleFilterAttribute(UserManager<IdentityUser> userManager)
        //{
        //    this.userManager = userManager;
        //}

        public string Permissions { get; set; } //Permission string to get from controller

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var a = context.HttpContext.User.Identity.Name;
            var claimsIndentity = context.HttpContext.User.Identity as ClaimsIdentity;

            //string currentUserRole = Convert.ToString(context.HttpContext.Request.Cookies//Session.TryGetValue("Permissions", out var role));

            foreach (var item in claimsIndentity.Claims)
            {
                var i = item.Value;
                if(i == Permissions)
                {
                    return;
                }
            } 

            context.Result = new UnauthorizedResult();
            return;
        }
    }
}
