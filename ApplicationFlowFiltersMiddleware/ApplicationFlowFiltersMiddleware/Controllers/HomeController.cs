using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApplicationFlowFiltersMiddleware.Models;
using ApplicationFlowFiltersMiddleware.Services;
using Microsoft.Extensions.Configuration;

namespace ApplicationFlowFiltersMiddleware.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IInstanceCounter instance;

        private readonly IConfiguration config;

        public HomeController(ILogger<HomeController> logger, IInstanceCounter instance,
            IConfiguration config)
        {
            _logger = logger;
            this.instance = instance;
            this.config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Error Handle Exception Handler
        public IActionResult Exception()
        {
            throw new Exception();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //Accesses from /Home/Config
        public IActionResult Config()
        {
            return Content(this.config["AddConfigActionInHomeController"]);           
        }

        public PartialViewResult PartialViewResult()
        {
            return PartialView("_PartialView");
        }

        //Test Error Handle Exception Status Code Pages
        public IActionResult StatusCodeError(int errorCode)
        {
            //if(errorCode == 404)
            //{
            //    return this.View("404ViewModel");
            //}
            return this.View();
        }

        //Error Handle
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
