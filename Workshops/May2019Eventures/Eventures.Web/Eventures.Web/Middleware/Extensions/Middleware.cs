namespace Eventures.Web.Middleware.Extensions
{
    using Microsoft.AspNetCore.Builder;

    public static class Middleware
    {
        public static IApplicationBuilder UseSeedMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Seed>();
        }
    }
}
