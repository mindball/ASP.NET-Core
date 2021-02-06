namespace ExercisesBookShopService2017.Services
{
    using Models.Category;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICategoryService
    {
        Task<IEnumerable<GetCategoryIdAndNameModelService>> AllAsync();

        Task<GetCategoryIdAndNameModelService> GetByIdAsync(int id);

        Task<bool> EditNameByIdAsync(int id, string name);

        Task<bool> Delete(int id);

        Task<int> Create(string name);
    }
}
