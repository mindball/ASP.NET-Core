﻿using LearningSystem.Data;
using LearningSystem.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace LearningSystem.Web.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope =
                app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetService<LearningSystemDbContext>();
                dbContext.Database.Migrate();

                var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                Task
                   .Run(async () =>
                   {
                       var adminName = WebConstants.AdministratorRole;
                       var roles = new[]
                       {
                            adminName,
                            WebConstants.BlogAuthorRole,
                            WebConstants.TrainerRole
                        };

                       foreach (var role in roles)
                       {
                           var roleExists = await roleManager.RoleExistsAsync(role);

                           if (!roleExists)
                           {
                               await roleManager.CreateAsync(new IdentityRole
                               {
                                   Name = role
                               });
                           }
                       }

                       var adminEmail = "admin@admin.com";
                       var adminUser = await userManager.FindByEmailAsync(adminEmail);

                       if (adminUser == null)
                       {
                           adminUser = new User
                           {
                               Email = adminEmail,
                               UserName = adminName,
                               Name = adminName,
                               Birthdate = DateTime.UtcNow
                           };

                           await userManager.CreateAsync(adminUser, "admin12");
                           await userManager.AddToRoleAsync(adminUser, adminName);
                       }
                   }).Wait();
            }

            return app;
        }
    }
}
