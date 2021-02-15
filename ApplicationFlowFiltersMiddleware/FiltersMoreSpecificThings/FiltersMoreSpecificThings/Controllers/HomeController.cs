namespace FiltersMoreSpecificThings.Controllers
{
    using FiltersMoreSpecificThings.Filters;
    using FiltersMoreSpecificThings.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Diagnostics;

    //Add to spccific controller
    //[TimeFilter]
    //[LogFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Add specific action
        [TimeFilter]
        public IActionResult Index()
        {
            return View();
        }

        //Add specific action
        [LogFilter]
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
