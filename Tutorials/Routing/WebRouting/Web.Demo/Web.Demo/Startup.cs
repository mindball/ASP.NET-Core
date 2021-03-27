using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Demo.Data;
using Web.Demo.Infrastructure;

namespace Web.Demo
{
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
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseInMemoryDatabase(databaseName: "test"));

            //ParameterTransformersController
            services.AddMvc().AddMvcOptions(options =>
            {
                options.Conventions.Add(new RouteTokenTransformerConvention(
                                            new SlugifyParameterTransformer()));
            });

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
            ////multiple parameters
            //endpoints.MapControllerRoute("parameters",
            //             "parameters/{level}/{type}/{id}", //-> work accessed -> https://localhost:5001/parameters/1/asd/2
            //              //"/parameters/{level}/{type}/{id}", -> work accessed -> https://localhost:5001/parameters/1/asd/2
            //              //"MultipleParameters/parameters/{level}/{type}/{id}", -> work accessed -> https://localhost:5001/MultipleParameters/parameters/1/asd/2
            //             defaults: new { controller = "MultipleParameters", action = "Parameters" });
            //endpoints.MapControllerRoute(name: "blog",
            //pattern: "blog/{*article}",
            //defaults: new { controller = "Blog", action = "Article" });
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapRazorPages();
            });
        }
    }
}
