namespace RepositoryServicePatternDemo.Core.Services
{
    using RepositoryServicePatternDemo.Core.Models;

    public interface IFinancialsService
    {
        decimal GetTotalSold();

        FinancialStats GetStats();
    }
}
