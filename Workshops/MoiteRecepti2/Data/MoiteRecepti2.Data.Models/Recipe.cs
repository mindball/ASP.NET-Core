namespace MoiteRecepti2.Data.Models
{
    using System;
    using System.Collections.Generic;

    using MoiteRecepti2.Data.Common.Models;

    public class Recipe : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Instructions { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public int PortionsCount { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public ICollection<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();

        public ICollection<Image> Images { get; set; } = new List<Image>();
    }
}
