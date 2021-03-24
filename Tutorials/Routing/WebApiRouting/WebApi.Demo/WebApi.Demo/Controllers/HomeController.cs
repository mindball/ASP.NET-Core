using Microsoft.AspNetCore.Mvc;

using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace WebApi.Demo.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/Index/{id?}")]
        public IActionResult Index()
        {
            var routedData = ControllerContext.RouteData.Values.Select(r => r.Value.ToString()).ToList();

            StringBuilder str = new StringBuilder();
            foreach (var item in routedData)
            {
                str.AppendLine(item);
            }

            return this.Content(str.ToString());
        }

        //Маршрутизирането с атрибутите изисква повече данни, за да се посочи маршрут
        //
        [Route("Home/About")]
        [Route("Home/About/{id?}")]
        public IActionResult MyAbout(int? id)
        {
            return this.Content(nameof(MyAbout) + " " + id);
        }
    }    
}
