namespace CarDealer.Web.Services
{
    using CarDealer.Web.Common;
    using CarDealer.Web.Data;
    using CarDealer.Web.Services.DTO.Customer;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CustomerService : ICustomerService
    {
        private readonly CarDealerDbContext dbContext;

        public CustomerService(CarDealerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<OrderCustomer> OrderCustomers(OrderType orderBy)
        {
            switch (orderBy)
            {
                case OrderType.Ascending:
                    return this.dbContext.Customers
                        .OrderBy(b => b.BirthDate)
                        .ThenBy(b => b.IsYoungDriver)
                        .Select(b => new OrderCustomer
                        {
                            Id = b.Id,
                            Name = b.Name,
                            Birthday = b.BirthDate,
                            IsYoungDriver = b.IsYoungDriver
                        })
                        .ToList();
                    break;
                case OrderType.Descending:
                    return this.dbContext.Customers
                        .OrderByDescending(b => b.BirthDate)
                        .ThenBy(b => b.IsYoungDriver)
                        .Select(b => new OrderCustomer
                        {
                            Id = b.Id,
                            Name = b.Name,
                            Birthday = b.BirthDate,
                            IsYoungDriver = b.IsYoungDriver
                        })
                        .ToList();
                    break;

                default:
                    throw new NotImplementedException($"Invalid order by {orderBy}");
            }
        }

        //Total Sales by Customer
        public CustomerSales TotalSalesByCustomer(int id)
        {
            if (!this.dbContext.Customers.Any(c => c.Id == id))
            {
                return null;
            }

            var result = this.dbContext.Customers
            .Where(c => c.Id == id)
            .Select(c => new CustomerSales
            {
                Name = c.Name,
                BoughtCarCount = c.Sales.Count,
                SpendMoney = c.Sales.Sum(s => s.Car.PartCars.Sum(p => (double)p.Part.Price))
            })
            .FirstOrDefault();

            return result;
        }       
    }
}
