namespace CarDealer.Web.Services
{
    using CarDealer.Web.Common;
    using CarDealer.Web.Services.DTO.Customer;
    using System.Collections.Generic;

    public interface ICustomerService
    {
        IEnumerable<OrderCustomer> OrderCustomers(OrderType orderBy);
    }
}
