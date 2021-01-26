namespace MoiteRecepti2.Web.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    using MoiteRecepti2.Services.Data;
    using MoiteRecepti2.Web.ViewModels.Recipes;

    public class RecipesController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IRecipesService recipesService;

        public RecipesController(
            ICategoryService categoryService,
            IRecipesService recipesService)
        {
            this.categoryService = categoryService;
            this.recipesService = recipesService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateRecipeInputViewModel();
            viewModel.CategoriesItems = this.categoryService.GetAllAsKeyValuePairs();

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRecipeInputViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoriesItems = this.categoryService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            await this.recipesService.CreateAsync(input);

            //return this.Json(input);

            //// TODO: Create recipe using service method
            //// TODO: Redirect to recipe info page
            return this.RedirectToAction("/");
        }
    }
}
