using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ApplicationFlowFiltersMiddleware.Filters
{
    public class AddHeaderActionAttributeFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("X-Info", context.ActionDescriptor.DisplayName);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add("X-Info-Result-Type", context.Result.GetType().Name);
        }
    }
}
