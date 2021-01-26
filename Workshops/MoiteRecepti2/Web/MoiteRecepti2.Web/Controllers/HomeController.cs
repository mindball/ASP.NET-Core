namespace MoiteRecepti2.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;
    using MoiteRecepti2.Services.Data;
    using MoiteRecepti2.Web.ViewModels;
    using MoiteRecepti2.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IGetCountsService countService;

        public HomeController(IGetCountsService countService)
        {
            this.countService = countService;
        }

        public IActionResult Index()
        {
            var modelData = this.countService.GetCounts();

            var viewModel = new IndexViewModel
            {
                CategoryCount = modelData.CategoryCount,
                ImagesCount = modelData.ImagesCount,
                IngredientsCount = modelData.IngredientsCount,
                RecipesCount = modelData.RecipesCount,
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
