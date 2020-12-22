namespace CatServerExercise.Handlers
{
    using CatServerExercise.Data;
    using CatServerExercise.Infastructure;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Linq;

    public class HomeHandler : IHandler
    {
        public int Order => 1;

        public Func<HttpContext, bool> Condition =>
            request => request.Request.Path.Value == "/"
                && request.Request.Method == HttpMethod.Get;

        //Branch
        public RequestDelegate RequestHandler => async (ctx) =>
        {
            var env = ctx.RequestServices.GetRequiredService<IWebHostEnvironment>();
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
        };
    }
}
