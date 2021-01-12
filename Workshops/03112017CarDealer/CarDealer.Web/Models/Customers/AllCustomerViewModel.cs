namespace CarDealer.Web.Models.Customers
{
    using CarDealer.Web.Common;
    using CarDealer.Web.Services.DTO.Customer;
    using System.Collections.Generic;

    public class AllCustomerViewModel
    {
        public IEnumerable<OrderCustomer> OrderCustomers { get; set; }

        public OrderType Order { get; set; }
    }
}
