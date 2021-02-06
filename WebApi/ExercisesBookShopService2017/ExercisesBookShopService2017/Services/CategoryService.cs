namespace ExercisesBookShopService2017.Services
{
    using AutoMapper.QueryableExtensions;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models.Category;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data.Models;

    public class CategoryService : ICategoryService
    {
        private readonly BookShopDbContext db;

        public CategoryService(BookShopDbContext db)
        {
            this.db = db;
        }


        public async Task<IEnumerable<GetCategoryIdAndNameModelService>> AllAsync()
                => await this.db.Categories
                    .ProjectTo<GetCategoryIdAndNameModelService>()
                    .ToListAsync();

        public async Task<int> Create(string name)
        {
            var exists = await this.db.Categories
                .AnyAsync(c => c.Name == name);

            if (exists)
            {
                return 0;
            }

            var category = new Category
            {
                Name = name
            };

            await this.db.Categories.AddAsync(category);
            await this.db.SaveChangesAsync();

            return category.CategoryId;
        }

        public async Task<bool> Delete(int id)
        {
            var category = await this.db.Categories
               .FirstOrDefaultAsync(c => c.CategoryId == id);

            if (category == null)
            {
                return false;
            }

            this.db.Remove(category);
            await this.db.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EditNameByIdAsync(int id, string name)
        {
            var exists = await this.db.Categories
                .AnyAsync(c => c.Name == name);

            var category = await this.db.Categories
                .FirstOrDefaultAsync(c => c.CategoryId == id);

            if (category == null || exists)
            {
                return false;
            }

            category.Name = name;
            await this.db.SaveChangesAsync();

            return true;
        }

        public async Task<GetCategoryIdAndNameModelService> GetByIdAsync(int id)
            => await this.db.Categories
                        .Where(c => c.CategoryId == id)
                        .ProjectTo<GetCategoryIdAndNameModelService>()
                        .FirstOrDefaultAsync();
    }
}
