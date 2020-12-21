namespace CatServerExercise
{
    using CatServerExercise.Data;
    using CatServerExercise.Infastructure;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using System.Linq;
    using System;
    using System.Threading.Tasks;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CatsDbContext>(options =>
            options.UseSqlServer(Configuration.ConnectionString));
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.Use((context, next) =>
            {
                context.RequestServices.GetRequiredService<CatsDbContext>().Database.Migrate();
                return next();
            });

            app.UseStaticFiles();

            app.Use((context, next) =>
            {
                context.Response.Headers.Add("Content-Type", "text/html");

                return next();
            });

            app.MapWhen(
                request => request.Request.Path.Value == "/"
                && request.Request.Method == HttpMethod.Get,
                home =>
                {
                    home.Run(async (ctx) =>
                    {
                        await ctx.Response.WriteAsync($"<h1>{env.ApplicationName}</h1>");

                        var db = ctx.RequestServices.GetService<CatsDbContext>();

                        var catData = db.Cats
                                    .Select(c => new
                                    {
                                        c.Id,
                                        c.Name
                                    })
                                    .ToList();

                        await ctx.Response.WriteAsync("<ul>");

                        foreach (var cat in catData)
                        {
                            await ctx.Response.WriteAsync($@"<li><a href=""/cat/{cat.Id}"">{cat.Name}</a></li>");
                        }

                        await ctx.Response.WriteAsync("</ul>");
                        await ctx.Response.WriteAsync(@"
                            <form action=""/cat/add"">
                                  <input type=""submit"" value=""Add Cat"" />
                            </form>");

                    });

                });

            app.MapWhen(
                 request => request.Request.Path.Value == "/cat/add",
                 catAdd =>
                 {
                     catAdd.Run(async (ctx) =>
                     {
                         if (ctx.Request.Method == HttpMethod.Get)
                         {
                             ctx.Response.StatusCode = 302;
                             ctx.Response.Redirect("/cats-add-form.html");
                         }
                         else if (ctx.Request.Method == HttpMethod.Post)
                         {
                             var db = ctx.RequestServices.GetService<CatsDbContext>();

                             var formData = ctx.Request.Form;

                             var cat = new Cat
                             {
                                 Name = formData["Name"],
                                 Age = int.Parse(formData["Age"]),
                                 Breed = formData["Breed"],
                                 ImageUrl = formData["catImageUrl"]
                             };

                             db.Add(cat);

                             try
                             {
                                 await db.SaveChangesAsync();

                                 ctx.Response.StatusCode = 302;
                                 ctx.Response.Redirect("/");
                             }
                             catch
                             {
                                 await ctx.Response.WriteAsync("<h2> Invalid cat data!</h2>");
                                 await ctx.Response.WriteAsync(@"<a href=""/cat/add"">Back to the form</a>");
                             }

                         }


                     });
                 });

            app.MapWhen(
                request => request.Request.Path.Value.StartsWith("/cat/")
                    && request.Request.Method == "GET",
                catDetails =>
                {
                   
                    catDetails.Run(async (context) =>
                    {
                        var urlParts = context.Request
                        .Path
                        .Value
                        .Split('/', StringSplitOptions.RemoveEmptyEntries);

                        if(urlParts.Length < 2)
                        {
                            context.Response.Redirect("/");
                            return;
                        }

                        var catId = urlParts[1];
                       

                        if (catId == null)
                        {
                            context.Response.Redirect("/");
                            return;
                        }

                        var db = context.RequestServices.GetRequiredService<CatsDbContext>();
                        var cat = await db.Cats.FindAsync(catId);
                        if (cat == null)
                        {
                            context.Response.Redirect("/");
                            return;
                        }

                        await context.Response.WriteAsync($"<h1>{cat.Name}</h1>");
                        await context.Response.WriteAsync($@"<img src=""{cat.ImageUrl}"" alt=""{cat.Name}"" width""300"" />");
                        await context.Response.WriteAsync($"<p>Age: {cat.Age}</h1>");
                        await context.Response.WriteAsync($"<p>Age: {cat.Breed}</h1>");


                    });

                });

           app.Run(async (context) =>
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("404 Page was not found :/");
            });
        }
    }
}
