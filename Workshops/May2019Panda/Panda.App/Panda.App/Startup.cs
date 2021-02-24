namespace Panda.App
{
    using AspNetCoreHero.ToastNotification;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;


    using Panda.Data;
    using Panda.Data.Seeding;
    using Panda.Domain;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PandaDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<PandaUser, PandaUserRole>()
               .AddEntityFrameworkStores<PandaDbContext>()
               .AddDefaultUI()
               .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 0;

                options.User.RequireUniqueEmail = true;
            });

            services.AddNotyf(config =>
            {
                config.DurationInSeconds = 10;
                config.IsDismissable = true;
                config.Position = NotyfPosition.BottomRight;
            });

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<PandaDbContext>();
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<PandaUserRole>>();
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<PandaUser>>();

                context.Database.EnsureCreated();
                //Problem with version EF core Upgraded from core 2.2 to 3.1
                //'System.Threading.Tasks.Task`1<Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry`1<!!0>> Microsoft.EntityFrameworkCore.DbContext.AddAsync(!!0, System.Threading.CancellationTokendocs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application
                //First migrations
                //dbContext.Database.Migrate();
                //new PandaDbContextSeeder().SeedAsync(context, serviceScope.ServiceProvider).GetAwaiter().GetResult();
                //Manual seeding
                ISeeder seed = new ShipStatusSeeder();
                seed.Seed(context);
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Packages}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
