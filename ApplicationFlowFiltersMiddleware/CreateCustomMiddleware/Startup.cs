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
            //The first Run() delegate terminates the pipeline
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("I`m the one and onle");
            });

            
            app.Use(async (context, next) =>
           {
               await context.Response.WriteAsync("1");
               //short-cirquit
               if (DateTime.Now.Second % 2 == 0)
               {
                   await next();
               }

               await context.Response.WriteAsync("6");
           });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("2");
                await next();
                await context.Response.WriteAsync("5");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("3");
                await context.Response.WriteAsync("4");
            });
        }
    }
}
