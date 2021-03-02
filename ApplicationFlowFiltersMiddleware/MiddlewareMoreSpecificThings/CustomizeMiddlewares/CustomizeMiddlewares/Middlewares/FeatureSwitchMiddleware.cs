using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomizeMiddlewares.Middlewares
{
    public class FeatureSwitchMiddleware
    {
        private readonly RequestDelegate _next;

        public FeatureSwitchMiddleware(RequestDelegate _next)
        {
            this._next = _next;
        }

        public async Task Invoke(HttpContext context, IConfiguration config)
        {
            if (context.Request.Path.Value.Contains("/features"))
            {
                var switches = config.GetSection("FeatureSwitches");

                var report = switches.GetChildren().Select(x => $"{x.Key} : {x.Value}");

                await context.Response.WriteAsync(string.Join("\n", report));
            }
            else 
            {
                await this._next(context);
            }           
        }
    }
}
