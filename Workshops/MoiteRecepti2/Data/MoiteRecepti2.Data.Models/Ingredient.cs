namespace MoiteRecepti2.Data.Models
{
    using System.Collections.Generic;

    using MoiteRecepti2.Data.Common.Models;

    public class Ingredient : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public ICollection<RecipeIngredient> Recipes { get; set; } = new List<RecipeIngredient>();
    }
}
