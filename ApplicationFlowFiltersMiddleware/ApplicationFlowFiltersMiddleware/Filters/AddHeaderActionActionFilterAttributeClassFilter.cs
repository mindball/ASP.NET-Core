using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ApplicationFlowFiltersMiddleware.Filters
{
    public class AddHeaderActionActionFilterAttributeClassFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("X-Info", context.ActionDescriptor.DisplayName);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add("X-Info-Result-Type", context.Result.GetType().Name);
        }
    }
}
