using CustomRouteConstraints.Data;
using CustomRouteConstraints.Data.Models;
using CustomRouteConstraints.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CustomRouteConstraints.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext context;

        public UsersController(ApplicationDbContext context)
        {
            this.context = context;
            SeedUsers();
        }

        public IActionResult Details(int id, string name)
        {
            var user = this.context.Users
                .Where(u => u.Id == id && u.LastName.Contains(name))
                .FirstOrDefault();

            return this.Content("");
        }

        private void SeedUsers()
        {
            var users = new List<User>
            {
                new User{ Id = 1, FirstName = "Pesho", LastName = "Goshov"},
                new User{ Id = 2, FirstName = "Ivan", LastName = "Gospodinov"},
                new User{ Id = 3, FirstName = "Dragan", LastName = "Balkanov"},
                new User{ Id = 4, FirstName = "Teo", LastName = "Ushev"},
            };

            this.context.AddRange(users);
            this.context.SaveChanges();
        }
    }
}
