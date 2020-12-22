namespace CatServerExercise.Handlers
{
    using CatServerExercise.Infastructure;
    using Microsoft.AspNetCore.Http;
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using CatServerExercise.Data;

    public class AddCatHandler : IHandler
    {
        public int Order => 2;

        public Func<HttpContext, bool> Condition =>
            request => request.Request.Path.Value == "/cat/add";

        public RequestDelegate RequestHandler => async (ctx) =>
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
        };
    }
}
