namespace CarDealer.Web.Controllers
{
    using CarDealer.Web.Common;
    using CarDealer.Web.Models.Customers;
    using CarDealer.Web.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("customers")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        //This route is customized
        [Route(nameof(All) + "/{orderBy?}")]
        public IActionResult All(string orderBy = "ascending")
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

        [Route("{id?}")]
        public IActionResult TotalSalesCustomer(int id) =>

            this.View("CustomerSales", this.customerService.TotalSalesByCustomer(id));
    }
}
