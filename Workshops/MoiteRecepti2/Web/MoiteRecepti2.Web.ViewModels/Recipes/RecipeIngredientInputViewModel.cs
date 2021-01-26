using System.ComponentModel.DataAnnotations;

namespace MoiteRecepti2.Web.ViewModels.Recipes
{
    public class RecipeIngredientInputViewModel
    {
        [Required]
        [MinLength(3)]
        public string IngredientName { get; set; }

        [Required]
        [MinLength(3)]
        public string Quantity { get; set; }
    }
}
