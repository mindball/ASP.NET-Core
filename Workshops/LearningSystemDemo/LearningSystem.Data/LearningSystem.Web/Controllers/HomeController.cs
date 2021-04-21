using LearningSystem.Services.Courses;
using LearningSystem.Services.Users;
using LearningSystem.Web.Models;
using LearningSystem.Web.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LearningSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICourseService courseService;
        private readonly IUsersService usersService;

        public HomeController(ICourseService courseService,
            IUsersService usersService)
        {
            this.courseService = courseService;
            this.usersService = usersService;
        }

        public async Task<IActionResult> Index()
        { 
            var viewModelResult = new HomeIndexViewModel
            {
                Courses = await this.courseService.ActiveAsync()
            };

            return this.View(viewModelResult);
        }

        public async Task<IActionResult> Search(SearchFormViewModel searchModel)
        {
            if(string.IsNullOrEmpty(searchModel.SearchText))
            {
                return this.RedirectToAction(nameof(Index));
            }

            var searchViewModel = new SearchViewModel { SearchText = searchModel.SearchText };

            if (searchModel.SearchCourses)
            {
                searchViewModel.Courses = 
                    await this.courseService.FindCoursesAsync(searchModel.SearchText);
            }

            if (searchModel.SearchUsers)
            {
                searchViewModel.Users =
                    await this.usersService.FindUsersAsync(searchModel.SearchText);
            }

            return this.View(searchViewModel);
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
