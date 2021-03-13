

namespace CreateAdminPanel.Extensions
{
    using CreateAdminPanel.Data;
    using CreateAdminPanel.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Threading.Tasks;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder MigrateDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetService<ApplicationDbContext>().Database.Migrate();

                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();

                Task.Run(async () =>
                {
                    var adminRoleName = GlobalConstants.AdminRoleName;
                    var adminRoleExist = await roleManager.RoleExistsAsync(adminRoleName);
                    if (!adminRoleExist)
                    {
                        await roleManager.CreateAsync(new IdentityRole(adminRoleName));
                    }
                   
                    var adminUserExist = await userManager.FindByNameAsync("admin@admin.com");
                    if(adminUserExist == null)
                    {
                        var user = new User
                        {
                            Email = "admin@admin.com",
                            UserName = "admin",
                            FirstName = "admin",
                            LastName = "admin"
                        };

                        var result = await userManager.CreateAsync(user, "1234");

                        var result2 = await userManager.AddToRoleAsync(user, adminRoleName);
                    }

                    //var studentRoleExists = await roleManager.RoleExistsAsync(GlobalConstants.StudentRoleName);
                    //if (!studentRoleExists)
                    //{
                    //    await roleManager.CreateAsync(new IdentityRole(GlobalConstants.StudentRoleName));
                    //}

                    //var trainerRoleExists = await roleManager.RoleExistsAsync(GlobalConstants.TrainerRoleName);
                    //if (!trainerRoleExists)
                    //{
                    //    await roleManager.CreateAsync(new IdentityRole(GlobalConstants.TrainerRoleName));
                    //}

                    //var blogAuthorRoleExists = await roleManager.RoleExistsAsync(GlobalConstants.BlogAuthorRolename);
                    //if (!blogAuthorRoleExists)
                    //{
                    //    await roleManager.CreateAsync(new IdentityRole(GlobalConstants.BlogAuthorRolename));
                    //}
                }).Wait();
            }

            return app;
        }
    }
}
