namespace CreateAndUseInMemoryDB.Extension
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public static class ApplicationBuilderExtensions
    {
        //Initialze Credentials(roles), register user in site Register action
        public static IApplicationBuilder CreateRoles(this IApplicationBuilder app)
        {
            using (var serviceScope =
                app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<IdentityUser>>();

                Task.Run(async () =>
                {
                    var adminRoleName = "Administrator";
                    var userRoleName = "Ordinary";

                    var adminRoleExist = await roleManager.RoleExistsAsync(adminRoleName);
                    var ordinaryRoleExist = await roleManager.RoleExistsAsync(userRoleName);

                    if (!adminRoleExist )
                    {
                        await roleManager.CreateAsync(new IdentityRole(adminRoleName));
                    }

                    if (!ordinaryRoleExist)
                    {
                        await roleManager.CreateAsync(new IdentityRole(userRoleName));
                    }

                    var admin = new IdentityUser
                    {
                        Email = "admin@admin.com",
                        UserName = "admin@admin.com"
                    };

                    await userManager.CreateAsync(admin, "admin@admin.com");

                    await userManager.AddToRoleAsync(admin, adminRoleName);

                    var user = new IdentityUser
                    {
                        Email = "test@test.com",
                        UserName = "test@test.com"
                    };

                    await userManager.CreateAsync(user, "test@test.com");

                    await userManager.AddToRoleAsync(user, userRoleName);
                })
                .Wait();

                return app;
            }
        }
    }
}
