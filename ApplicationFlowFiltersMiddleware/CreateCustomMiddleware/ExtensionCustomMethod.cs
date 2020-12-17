using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateCustomMiddleware
{
    public static class ExtensionCustomMethod
    {
        public static IApplicationBuilder ExtensionUseCustom(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<EveryTwoSecondsMiddleware>();
        }
    }
}
