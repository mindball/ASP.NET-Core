namespace CatServerExercise.Handlers
{
    using CatServerExercise.Data;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class CatAdded : IHandler
    {
        public int Order => 3;
        public Func<HttpContext, bool> Condition =>
            request => request.Request.Path.Value.StartsWith("/cat/")
                    && request.Request.Method == "GET";


        public RequestDelegate RequestHandler => async (context) =>
        {
            var urlParts = context.Request
            .Path
            .Value
            .Split('/', StringSplitOptions.RemoveEmptyEntries);

            if (urlParts.Length < 2)
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
        };
    }
}
