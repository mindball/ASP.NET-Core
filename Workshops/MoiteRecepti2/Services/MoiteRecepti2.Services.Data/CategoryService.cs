namespace MoiteRecepti2.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using MoiteRecepti2.Data.Common.Repositories;
    using MoiteRecepti2.Data.Models;

    public class CategoryService : ICategoryService
    {
        private IDeletableEntityRepository<Category> categoriesRepo;

        public CategoryService(IDeletableEntityRepository<Category> categoriesRepo)
        {
            this.categoriesRepo = categoriesRepo;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
         => this.categoriesRepo.All().Select(x => new
         {
             x.Id,
             x.Name,
         }).ToList()
            .Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
    }
}
