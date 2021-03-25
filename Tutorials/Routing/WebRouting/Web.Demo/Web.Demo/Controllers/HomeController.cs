using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Demo.Models;

namespace Web.Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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

        //if [Route("~/Privacy")] is enable -> https://localhost:5001/Privacy accessed
        //or https://localhost:5001/Home/Privacy
        [Route("~/Privacy")]
        public IActionResult Privacy()
        {
            return this.Content(nameof(Privacy));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
