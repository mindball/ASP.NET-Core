using ConfigurationInAsp.NetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationInAsp.NetCore.Controllers
{
    public class HomeController : Controller
    {
        private IConfigurationRoot ConfigRoot;
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration configRoot,
            IConfiguration configuration)
        {
            this.ConfigRoot = (IConfigurationRoot)configRoot;
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllProviders()
        {
            string str = "";
            foreach (var provider in ConfigRoot.Providers.ToList())
            {
                str += provider.ToString() + "\n";
            }

            return Content(str);
        }

        public IActionResult AppSettings()
        {
            var myKeyValue = this.configuration["MyKey"];
            var title = this.configuration["Position:Title"];
            var name = this.configuration["Position:Name"];
            var defaultLogLevel = this.configuration["Logging:LogLevel:Default"];


            return Content($"MyKey value: {myKeyValue} \n" +
                           $"Title: {title} \n" +
                           $"Name: {name} \n" +
                           $"Default Log Level: {defaultLogLevel}");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
