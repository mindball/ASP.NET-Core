using ApproachWithDIMicrosoftVersion.Data;
using ApproachWithDIMicrosoftVersion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ApproachWithDIMicrosoftVersion.Controllers
{
    public class HomeController : Controller
    {
        private readonly RazorPagesMovieContext context;

        public HomeController(RazorPagesMovieContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allMovie = await this.context.Movies.ToListAsync();

            return View(allMovie);
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
