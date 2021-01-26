namespace MoiteRecepti2.Data.Models
{
    using MoiteRecepti2.Data.Common.Models;

    public class Setting : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
