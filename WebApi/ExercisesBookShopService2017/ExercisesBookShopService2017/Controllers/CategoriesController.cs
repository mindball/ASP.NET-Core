namespace ExercisesBookShopService2017.Controllers
{

    using Infrastructure.Extensions;
    using Infrastructure.Filters;
    using Microsoft.AspNetCore.Mvc;
    using Models.Categories;
    using Services;
    using System.Threading.Tasks;


    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
            => this.OkOrNotFound(await this.categoryService.AllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
            => this.OkOrNotFound(await this.categoryService.GetByIdAsync(id));

        [HttpPut("{id}")]
        [ValidateModelState]
        public async Task<IActionResult> Edit(int id, [FromBody] EditCategoryNameRequestApiModel model)
        {
            var success = await this.categoryService.EditNameByIdAsync(id, model.Name);

            if (!success)
            {
                return this.BadRequest($@"Category with Id {id} does not exist or Name: ""{model.Name}"" already exists.");
            }

            return this.Ok(await this.GetById(id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await this.categoryService.Delete(id);

            if (!success)
            {
                return this.BadRequest($"Category with Id {id} does not exist");
            }

            return this.Ok("Deleted");
        }

        [HttpPost]
        [ValidateModelState]
        public async Task<IActionResult> Create([FromBody] CreateCategoryRequestApiModel model)
        {
            var idResult = await this.categoryService.Create(model.Name);

            if (idResult == 0)
            {
                return this.BadRequest($@"Category with Name: ""{model.Name}"" already exists.");
            }

            return this.Ok(idResult);
        }
    }
}
