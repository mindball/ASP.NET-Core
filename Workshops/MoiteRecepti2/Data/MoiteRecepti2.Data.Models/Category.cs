namespace MoiteRecepti2.Data.Models
{
    using System.Collections.Generic;

    using MoiteRecepti2.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}
