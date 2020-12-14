using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorView.Data;
using RazorView.Models;
using RazorView.ViewModels.Home;
using System;
using System.Diagnostics;
using System.Linq;

namespace RazorView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext dbContext;

        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }


        public IActionResult Index(int id)
        {
            var viewModel = new IndexViewModel
            {
                Id = id,
                Name = "Anonymous",
                Year = DateTime.UtcNow.Year,
                Processors = Environment.ProcessorCount,
                UsersCount = this.dbContext.Users.Count(),
                Users = this.dbContext.Users.Select(u => u.UserName).ToList(),
                Description = "Курсът \"ASP.NET Core\" ще ви научи как се изграждат съвременни уеб приложения с архитектурата Model-View-Controller, използвайки HTML5, бази данни, Entity Framework Core и други технологии. Изучава се технологичната платформа ASP.NET Core, нейните компоненти и архитектура, създаването на MVC уеб приложения, дефинирането на модели, изгледи и частични изгледи с Razor view engine, дефиниране на контролери, работа с бази данни и интеграция с Entity Framework Core, LINQ и SQL Server. Курсът включа и по-сложни теми като работа с потребители, роли и сесии, използване на AJAX, кеширане, сигурност на уеб приложенията, уеб сокети и работа с библиотеки от MVC контроли.",
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            //var viewModel = new IndexViewModel
            //{
            //    Id = id,
            //    Name = "Anonymous",
            //    Year = DateTime.UtcNow.Year,
            //    Processors = Environment.ProcessorCount,
            //    UsersCount = this.dbContext.Users.Count(),
            //    Description = "Курсът \"ASP.NET Core\" ще ви научи как се изграждат съвременни уеб приложения с архитектурата Model-View-Controller, използвайки HTML5, бази данни, Entity Framework Core и други технологии. Изучава се технологичната платформа ASP.NET Core, нейните компоненти и архитектура, създаването на MVC уеб приложения, дефинирането на модели, изгледи и частични изгледи с Razor view engine, дефиниране на контролери, работа с бази данни и интеграция с Entity Framework Core, LINQ и SQL Server. Курсът включа и по-сложни теми като работа с потребители, роли и сесии, използване на AJAX, кеширане, сигурност на уеб приложенията, уеб сокети и работа с библиотеки от MVC контроли.",
            //};

            //return View(viewModel);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
