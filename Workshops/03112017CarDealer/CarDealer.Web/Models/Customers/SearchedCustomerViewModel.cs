namespace CarDealer.Web.Models.Customers
{
    using CarDealer.Web.Services.DTO.Customer;
    using System;
    using System.Collections.Generic;

    public class SearchedCustomerViewModel
    {
        public IEnumerable<OrderCustomer> OrderCustomers { get; set; }

        public string SearchCustomerName { get; set; }
    }
}
