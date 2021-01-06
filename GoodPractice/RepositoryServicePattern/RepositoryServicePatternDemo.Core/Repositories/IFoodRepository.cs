namespace RepositoryServicePatternDemo.Core.Repositories
{
    using RepositoryServicePatternDemo.Core.Models;
    using System.Collections.Generic;

    public interface IFoodRepository
    {
        List<FoodItem> GetAllSold();
    }
}
