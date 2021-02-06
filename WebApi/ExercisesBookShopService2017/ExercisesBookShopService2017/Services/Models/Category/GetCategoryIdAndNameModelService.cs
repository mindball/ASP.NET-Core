namespace ExercisesBookShopService2017.Services.Models.Category
{
    using Common.Mapping;
    using Data.Models;

    public class GetCategoryIdAndNameModelService : IMapFrom<Category>
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
}
