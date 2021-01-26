namespace MoiteRecepti2.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using MoiteRecepti2.Data.Common.Repositories;
    using MoiteRecepti2.Data.Models;
    using MoiteRecepti2.Web.ViewModels.Recipes;

    public class RecipesService : IRecipesService
    {
        private readonly IDeletableEntityRepository<Recipe> recipesRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredientsRespository;

        public RecipesService(
            IDeletableEntityRepository<Recipe> recipesRepository,
            IDeletableEntityRepository<Ingredient> ingredientsRespository)
        {
            this.recipesRepository = recipesRepository;
            this.ingredientsRespository = ingredientsRespository;
        }

        public async Task CreateAsync(CreateRecipeInputViewModel input)
        {
            var recipe = new Recipe
            {
                CategoryId = input.CategoryId,
                CookingTime = TimeSpan.FromMinutes(input.CookingTime),
                Instructions = input.Instructions,
                Name = input.Name,
                PortionsCount = input.PortionsCount,
                PreparationTime = TimeSpan.FromMinutes(input.PreparationTime),
            };

            foreach (var inputIngredient in input.Ingredients)
            {
                var ingredient = this.ingredientsRespository.All().FirstOrDefault(x => x.Name == inputIngredient.IngredientName);
                if (ingredient == null)
                {
                    ingredient = new Ingredient { Name = inputIngredient.IngredientName };
                }

                recipe.Ingredients.Add(new RecipeIngredient
                {
                    Ingredient = ingredient,
                    Quantity = inputIngredient.Quantity,
                });
            }

            await this.recipesRepository.AddAsync(recipe);
            await this.recipesRepository.SaveChangesAsync();
        }
    }
}
