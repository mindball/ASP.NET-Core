﻿namespace RepositoryServicePatternDemo.Core.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class FinancialStats
    {
        [DisplayName("Avg. Ticket Profit: ")]
        [DataType(DataType.Currency)]
        public decimal AverageTicketProfit { get; set; }


        [DisplayName("Avg. Food Item Profit: ")]
        [DataType(DataType.Currency)]
        public decimal AverageFoodItemProfit { get; set; }
    }
}
