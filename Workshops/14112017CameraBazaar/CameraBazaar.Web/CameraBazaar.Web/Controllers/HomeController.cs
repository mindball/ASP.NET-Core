namespace CameraBazaar.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Diagnostics;

    using CameraBazaar.Web.Models;
    using CameraBazaar.Services.Contracts;

    public class HomeController : Controller
    {
        private readonly ICameraService cameraService;

        public HomeController(ICameraService cameraService)
        {
            this.cameraService = cameraService;
        }

        public IActionResult Index()
        {
            var cameras = this.cameraService.GetAllCamerasDetails();

            return View(cameras);
        }

        public IActionResult Error()
        {
            return View(new Error { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
