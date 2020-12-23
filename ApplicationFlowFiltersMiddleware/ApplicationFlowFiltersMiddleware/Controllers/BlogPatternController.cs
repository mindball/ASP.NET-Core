using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text;

namespace ApplicationFlowFiltersMiddleware.Controllers
{
    public class BlogPatternController : Controller
    {
        //Two way to ignore date from end point '?' and this method MVC ignore date with one parameter
        public IActionResult Details(string title)
        {
            var controllerName = this.GetType().Name;
            var actionName = MethodBase.GetCurrentMethod().Name;
            var parameters = MethodBase.GetCurrentMethod().GetParameters();
          
            StringBuilder builder = new StringBuilder();
            string delimiter = "";
            foreach (var parameter in parameters)
            {
                builder.Append(delimiter);
                builder.Append(parameter.ToString());
                delimiter = ",";
            }

            string actionParameters = builder.ToString();

            return this.Content($"Execute route /blog/controller={controllerName}/action={actionName}/parameters={actionParameters}");
        }

        //Accept datew
        //public IActionResult Details(string title, string date)
        //{
        //    var controllerName = this.GetType().Name;
        //    var actionName = MethodBase.GetCurrentMethod().Name;
        //    var parameters = MethodBase.GetCurrentMethod().GetParameters();

        //    StringBuilder builder = new StringBuilder();
        //    string delimiter = "";
        //    foreach (var parameter in parameters)
        //    {
        //        builder.Append(delimiter);
        //        builder.Append(parameter.ToString());
        //        delimiter = ",";
        //    }

        //    string actionParameters = builder.ToString();

        //    return this.Content($"Execute route /blog/controller={controllerName}/action={actionName}/parameters={actionParameters}");
        //}
    }
}
