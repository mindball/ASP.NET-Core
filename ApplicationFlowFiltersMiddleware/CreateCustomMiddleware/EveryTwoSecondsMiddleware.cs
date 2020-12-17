using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateCustomMiddleware
{
    public class EveryTwoSecondsMiddleware
    {
        private readonly RequestDelegate next;

        public EveryTwoSecondsMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public  async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("1");
            //short-cirquit
            if (DateTime.Now.Second % 2 == 0)
            {
                await this.next(context);
            }

            await context.Response.WriteAsync("6");
        }

        ////Dependency injection
        //public async Task InvokeAsync(HttpContext context, IInstanceCounter counter)
        //{
        //    await context.Response.WriteAsync("1");
        //    //short-cirquit
        //    if (DateTime.Now.Second % 2 == 0)
        //    {
        //        await this.next(context);
        //    }

        //    await context.Response.WriteAsync("6");
        //}
    }
}
