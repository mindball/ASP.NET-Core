using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CreateCustomMiddleware
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Run, Use
            //The first Run() delegate terminates the pipeline
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("I`m the one and onle");
            //});

            // app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("1");
            //    //short-cirquit
            //    if (DateTime.Now.Second % 2 == 0)
            //    {
            //        await next();
            //    }

            //    await context.Response.WriteAsync("6");
            //});

            //Use custom middleware (може да си правим и extension methods)
            //app.UseMiddleware<EveryTwoSecondsMiddleware>();

            // app.Use(async (context, next) =>
            // {
            //     await context.Response.WriteAsync("2");
            //     await next();
            //     await context.Response.WriteAsync("5");
            // });

            // app.Use(async (context, next) =>
            // {
            //     await context.Response.WriteAsync("3");
            //     await context.Response.WriteAsync("4");
            // });

            //Extension middleware
            app.ExtensionUseCustom();

            //Map 
            app.Map("/softuni", app =>
            {
                app.UseWelcomePage();   //http://localhost:port/softuni
                //тези middleware важат самота за softuni ако извън map имаме middleware 
                //те не важат за този адрес
                //Имаме възможност в този адрес да направим друг Map:
                app.Map("/welcome", app =>
                {
                    app.Run(async (request) =>
                        await request.Response.WriteAsync("Inner map"));
                });
                
            });

            //Имаме възможност в този адрес да направим друг Map:
            app.Map("/softuni", app =>
            {  
                app.Map("/welcome", app => //http://localhost:port/softuni/welcome
                {
                    app.Run(async (request) =>
                        await request.Response.WriteAsync("Inner map"));
                });
                app.UseWelcomePage();   //http://localhost:port/softuni
            });
        }
    }
}
