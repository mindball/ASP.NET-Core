namespace CatServerExercise.Middleware
{
    using Microsoft.AspNetCore.Http;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using CatServerExercise.Data;
    using Microsoft.EntityFrameworkCore;

    public class DatabaseMigrationMiddleware
    {
        private readonly RequestDelegate next;
       
        public DatabaseMigrationMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.RequestServices.GetRequiredService<CatsDbContext>().Database.Migrate();

            await this.next(context);
        }
    }
}
