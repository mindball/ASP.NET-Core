namespace RepositoryServicePatternDemo.Core.Services
{
    using System;
    using System.Linq;
    using RepositoryServicePatternDemo.Core.Models;
    using RepositoryServicePatternDemo.Core.Repositories;

    public class FinancialsService : IFinancialsService
    {

        private readonly ITicketRepository ticketRepo;
        private readonly IFoodRepository foodRepo;

        public FinancialsService(ITicketRepository ticketRepo, IFoodRepository foodRepo)
        {
            this.ticketRepo = ticketRepo;
            this.foodRepo = foodRepo;
        }

        public FinancialStats GetStats()
        {
            FinancialStats stats = new FinancialStats();

            var foodsSold = this.foodRepo.GetAllSold();
            var ticketsSold = this.ticketRepo.GetAllSold();

            // Calculate Average Stats
            stats.AverageTicketProfit = ticketsSold.Sum(x => x.Profit) / ticketsSold.Sum(x => x.Quantity);
            stats.AverageFoodItemProfit = foodsSold.Sum(x => x.Profit) / foodsSold.Sum(x => x.Quantity);

            return stats;
        }

        public decimal GetTotalSold()
        {
            var foodsSold = this.foodRepo.GetAllSold().Sum(x => x.Profit);
            var ticketsSold = this.ticketRepo.GetAllSold().Sum(x => x.Profit);

            return foodsSold + ticketsSold;
        }
    }
}
