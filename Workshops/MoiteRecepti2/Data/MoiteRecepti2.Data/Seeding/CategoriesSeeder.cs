namespace MoiteRecepti2.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using MoiteRecepti2.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.AddAsync(new Category { Name = "Тарт" });
            await dbContext.AddAsync(new Category { Name = "Кекс" });
            await dbContext.AddAsync(new Category { Name = "Печено свинско" });

            await dbContext.SaveChangesAsync();
        }
    }
}
