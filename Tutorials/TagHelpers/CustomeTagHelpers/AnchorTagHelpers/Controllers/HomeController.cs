using AnchorTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AnchorTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var t = this.HttpContext.Request.RouteValues;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Parameters(int level, string type, int id)
        {

            var isQueryStringExist = this.Request.Query.ContainsKey("postTitle");
            var queryStringValue = this.Request.QueryString.Value;

            return this.Content($"Route value contain request query {isQueryStringExist} and value is {queryStringValue}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
