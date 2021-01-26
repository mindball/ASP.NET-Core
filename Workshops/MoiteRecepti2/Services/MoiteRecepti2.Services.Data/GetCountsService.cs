namespace MoiteRecepti2.Services.Data
{
    using System.Linq;

    using MoiteRecepti2.Data.Common.Repositories;
    using MoiteRecepti2.Data.Models;
    using MoiteRecepti2.Web.ViewModels.Home;

    public class GetCountsService : IGetCountsService
    {
        private IDeletableEntityRepository<Category> categoriesRepo;
        private IRepository<Image> imagesRepository;
        private IDeletableEntityRepository<Ingredient> ingrediantsRepo;
        private IDeletableEntityRepository<Recipe> recipeRepo;

        public GetCountsService(
            IDeletableEntityRepository<Category> categoriesRepo,
            IRepository<Image> imagesRepository,
            IDeletableEntityRepository<Ingredient> ingrediantsRepo,
            IDeletableEntityRepository<Recipe> recipeRepo)
        {
            this.categoriesRepo = categoriesRepo;
            this.imagesRepository = imagesRepository;
            this.ingrediantsRepo = ingrediantsRepo;
            this.recipeRepo = recipeRepo;
        }

        public CountsServiceModel GetCounts()
        {
            var serviceModel = new CountsServiceModel()
            {
                CategoryCount = this.categoriesRepo.All().Count(),
                ImagesCount = this.imagesRepository.All().Count(),
                IngredientsCount = this.ingrediantsRepo.All().Count(),
                RecipesCount = this.recipeRepo.All().Count(),
            };

            return serviceModel;
        }
    }
}
