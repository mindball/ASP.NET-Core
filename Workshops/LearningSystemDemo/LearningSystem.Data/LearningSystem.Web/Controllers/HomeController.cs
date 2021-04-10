using LearningSystem.Services.Courses;
using LearningSystem.Web.Models;
using LearningSystem.Web.Models.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICourseService courseService;

        public HomeController(ICourseService courseService)
        {
            this.courseService = courseService;

        }

        public async Task<IActionResult> Index()
        { 
            var viewModelResult = new HomeIndexViewModel
            {
                Courses = await this.courseService.ActiveAsync()
            };

            return this.View(viewModelResult);
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
