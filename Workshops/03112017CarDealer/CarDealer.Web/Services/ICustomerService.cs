namespace CarDealer.Web.Services
{
    using CarDealer.Web.Common;
    using CarDealer.Web.Services.DTO.Customer;
    using System;
    using System.Collections.Generic;

    public interface ICustomerService
    {
        IEnumerable<OrderCustomer> OrderCustomers(OrderType orderBy);

        CustomerSales TotalSalesByCustomer(int id);

        OrderCustomer CustomerEdit(int id);

        void Edit(int id, string name, DateTime birthday, bool isYoungDriver);

        void Create(string name, DateTime birthday, bool isYoundDriver);
    }
}
