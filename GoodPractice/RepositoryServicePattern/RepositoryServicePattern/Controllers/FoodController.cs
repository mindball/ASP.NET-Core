namespace RepositoryServicePattern.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RepositoryServicePatternDemo.Core.Services;

    public class FoodController : Controller
    {
        private readonly IFoodService foodService;

        public FoodController(IFoodService foodService)
        {
            this.foodService = foodService;
        }

        public IActionResult Index()
        {
            var itemSold = this.foodService.GetAllSold();

            return View(itemSold);
        }
    }
}
