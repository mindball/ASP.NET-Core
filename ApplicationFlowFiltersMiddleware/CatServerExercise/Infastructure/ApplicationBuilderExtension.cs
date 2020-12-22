namespace CatServerExercise.Infastructure
{
    using CatServerExercise.Handlers;
    using CatServerExercise.Middleware;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Linq;
    using System.Reflection;

    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseDatabaseMigration(
            this IApplicationBuilder builder) => builder.UseMiddleware<DatabaseMigrationMiddleware>();


        public static IApplicationBuilder UseHtmlContentType(
            this IApplicationBuilder builder) => builder.UseMiddleware<HtmlContentTypeMiddleware>();

        public static IApplicationBuilder UseRequestaHandlers(
            this IApplicationBuilder builder)
        {
            //Get all handlers, whick implement and inherits IHandler
            var handlers = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && typeof(IHandler).IsAssignableFrom(t))
                .Select(Activator.CreateInstance)
                .Cast<IHandler>()
                .OrderBy(h => h.Order);

            foreach (var handler in handlers)
            {
                builder.MapWhen(handler.Condition, app =>
                {
                    app.Run(handler.RequestHandler);
                });
            }
            
            return builder;
        }

        public static void UseNotFoundHandler(
            this IApplicationBuilder builder)
        {
            builder.Run(async (context) =>
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("404 page was not found :/");
            });
        }
    }
}
