namespace MoiteRecepti2.Services.Data
{
    using System.Threading.Tasks;

    using MoiteRecepti2.Web.ViewModels.Recipes;

    public interface IRecipesService
    {
        Task CreateAsync(CreateRecipeInputViewModel input);
    }
}
