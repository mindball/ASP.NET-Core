namespace MoiteRecepti2.Web.ViewModels.Recipes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateRecipeInputViewModel
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        [Required]
        [MinLength(100)]
        public string Instructions { get; set; }

        [Range(0, 24 * 60)]
        [Display(Name = "Preparation Time(in minutes)")]
        public int PreparationTime { get; set; }

        [Range(0, 24 * 60)]
        [Display(Name = "Cooking Time(in minutes)")]
        public int CookingTime { get; set; }

        [Range(1, 100)]
        [Display(Name = "Portions count")]
        public int PortionsCount { get; set; }

        public IEnumerable<RecipeIngredientInputViewModel> Ingredients { get; set; }

        [Display(Name = "Category item")]
        public int CategoryId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
    }
}
