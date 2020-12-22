namespace CatServerExercise.Middleware
{
    using Microsoft.AspNetCore.Http;
    using System.Threading.Tasks;

    public class HtmlContentTypeMiddleware
    {
        private readonly RequestDelegate next;

        public HtmlContentTypeMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.Headers.Add("Content-Type", "text/html");
            await this.next(context);
        } 

    }
}
