using CarDealer.Web.Common;
using CarDealer.Web.Services.DTO.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Models.Customers
{
    public class AllCustomerViewModel
    {
        public IEnumerable<OrderCustomer> OrderCustomers {get; set;}

        public OrderType Order { get; set; }
    }
}
