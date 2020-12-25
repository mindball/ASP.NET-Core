using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Web.Common;
using CarDealer.Web.Models.Customers;
using CarDealer.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Web.Controllers
{
    [Route("customers")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [Route(nameof(All) + "/{orderBy?}")]
        public IActionResult All(string orderBy)
        {
            OrderType orderType =
                orderBy == "descending" ?
                    OrderType.Descending :
                    OrderType.Ascending;

            var customers = this.customerService.OrderCustomers(orderType);
            var customersView = new AllCustomerViewModel
            {
                OrderCustomers = customers,
                Order = orderType
            };

            return View(customersView);
        }
    }
}
