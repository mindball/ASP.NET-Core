using ApplicationFlowFiltersMiddleware.Services;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationFlowFiltersMiddleware.Filters
{
    public class FilterDependencyInjectionTypeFilter : IActionFilter
    {
        private readonly IInstanceCounter counter;

        public FilterDependencyInjectionTypeFilter(IInstanceCounter counter)
        {
            this.counter = counter;
        }

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
