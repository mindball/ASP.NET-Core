using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;

namespace CustomRouteConstraints.Infrastructure
{
    public class RequiredPositiveIntRouteConstraint : IRouteConstraint
    {
        //The segment must be an integer.
        //The segment must be greater than or equal to 1.
        //The segment must exist.
        public bool Match(HttpContext httpContext, 
            IRouter route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            return new IntRouteConstraint().Match(httpContext, route, routeKey, values, routeDirection)
            && new RequiredRouteConstraint().Match(httpContext, route, routeKey, values, routeDirection)
            && new MinRouteConstraint(1).Match(httpContext, route, routeKey, values, routeDirection);
        }
    }
}
