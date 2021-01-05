namespace CarDealer.Web.Controllers
{
    using CarDealer.Web.Common;
    using CarDealer.Web.Models.Customers;
    using CarDealer.Web.Services;
    using Microsoft.AspNetCore.Mvc;
    using System;

    [Route("customers")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [Route(nameof(Create))]
        public IActionResult Create() => this.View();

        [HttpPost(nameof(Create))]
        public IActionResult Create(CreateCustomerViewModel customerModel)
        {
            if (customerModel == null && !ModelState.IsValid)
            {
                return this.View(customerModel);
            }

            this.customerService.Create(customerModel.Name, customerModel.Birthday, customerModel.IsYoungDriver);

            return this.RedirectToAction(nameof(All));
        }

        [HttpGet(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id)
        {
            var customer = this.customerService.CustomerEdit(id);
            var customerModel = new CustomerViewModel
            {
                Id = customer.Id,
                Name = customer.Name,
                Birthday = customer.Birthday
            };

            return this.View(customerModel);
        }


        [HttpPost(nameof(Edit) + "/{id}")]
        public IActionResult Edit(CustomerViewModel customer) 
        {

            if (customer != null && ModelState.IsValid)
            {
                this.customerService.Edit(customer.Id, customer.Name, customer.Birthday);

                return RedirectToAction(nameof(All));
            }

            return this.RedirectToAction(nameof(All));
        }

        //This route is customized
        [Route(nameof(All) + "/{orderBy?}")]
        public IActionResult All(string orderBy = "descending")
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
        public IActionResult CustomerSales(int id)
        {            
           this.customerService.TotalSalesByCustomer(id);
           return this.View(this.customerService.TotalSalesByCustomer(id));
        }
    }
}
