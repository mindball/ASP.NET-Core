namespace ExercisesBookShopService2017.Models.Categories
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants;

    public class CreateCategoryRequestApiModel
    {
        [Required]
        [MinLength(CategoryNameMinLeght)]
        [MaxLength(CategoryNameMaxLeght)]
        public string Name { get; set; }
    }
}
