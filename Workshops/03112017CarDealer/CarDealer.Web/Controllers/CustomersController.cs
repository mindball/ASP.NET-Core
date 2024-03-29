﻿namespace CarDealer.Web.Controllers
{
    using CarDealer.Web.Common;
    using CarDealer.Web.Models.Customers;
    using CarDealer.Web.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("customers")]
    public class CustomersController : Controller
    {
        private OrderType orderType = OrderType.Descending;
        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [Route(nameof(Create))]
        public IActionResult Create() => this.View();

        [HttpPost(nameof(Create))]
        public IActionResult Create(CustomerFormViewModel customerModel)
        {
            if (customerModel == null || !ModelState.IsValid)
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
            var customerModel = new CustomerFormViewModel
            {
                Id = customer.Id,
                Name = customer.Name,
                Birthday = customer.Birthday,
                IsYoungDriver = customer.IsYoungDriver                
            };

            return this.View(customerModel);
        }

        [HttpPost(nameof(Edit) + "/{id}")]
        public IActionResult Edit(CustomerFormViewModel customer) //CustomerViewModel customer use partial view reuse form in html) 
        {

            if (customer != null || ModelState.IsValid)
            {
                this.customerService.Edit(customer.Id, customer.Name, customer.Birthday, customer.IsYoungDriver);

                return RedirectToAction(nameof(All));
            }

            return this.RedirectToAction(nameof(All));
        }

        //This route is customized
        [Route(nameof(All) + "/{orderBy?}")]
        public IActionResult All(string orderBy = "descending")
        {
            orderType = orderBy == "descending" ?
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

        [Route("{id?}", Order = 2)]
        public IActionResult CustomerSales(int id)
        {            
           this.customerService.TotalSalesByCustomer(id);
           return this.View(this.customerService.TotalSalesByCustomer(id));
        }

        [Route(nameof(SearchCustomers) + "/{search?}")]
        public IActionResult SearchCustomers(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                var customers = this.customerService.OrderCustomers(orderType);
                var customersView = new AllCustomerViewModel
                {
                    OrderCustomers = customers,
                    Order = orderType
                };

                return this.View("All", customersView);
            }

            var searchedCustomers = this.customerService.SearchCustomers(search.ToLower());
            var searchedCustomersViewModel = new SearchedCustomerViewModel
            {
                OrderCustomers = searchedCustomers,
                SearchCustomerName = search
            };

            return this.View(searchedCustomersViewModel);
        }
    }
}
