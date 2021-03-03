namespace CreateAndUseInMemoryDB.Controllers
{
    using CreateAndUseInMemoryDB.Data;
    using CreateAndUseInMemoryDB.Filters.ActionFilters;
    using CreateAndUseInMemoryDB.Filters.AuthorizationFilters;
    using CreateAndUseInMemoryDB.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Diagnostics;
    using System.Linq;

    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger,
             ApplicationDbContext db)
        {
            this.db = db;
            _logger = logger;
        }


        [TimeFilter]
        public IActionResult Index()
        {
            return View();
        }

        //Show autorize user and Anonymous
        [LogFilter]
        /* 
         * 15.02.2021 7:24:39 – ::1 – test@test.com – HomeController.Privacy
         *  15.02.2021 7:24:50 – ::1 – Anonymous – HomeController.Privacy   
         *  Create a inMemoryDb to easy test logged users
         */
        public IActionResult Privacy()
        {
            return View();
        }

        [RoleFilter(Permissions = "Administrator")]
        public IActionResult Permission()
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
