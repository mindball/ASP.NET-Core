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

        public void Create(string name, DateTime birthday, bool isYoundDriver)
        {
            var customer = new Customer
            {
                Name = name,
                BirthDate = birthday,
                IsYoungDriver = isYoundDriver
            };

            this.dbContext.Customers.Add(customer);

            this.dbContext.SaveChanges();
        }

        public OrderCustomer CustomerEdit(int id)
        {
            if (!this.dbContext.Customers.Any(c => c.Id == id))
            {
                return null;
            }

            var customer = this.dbContext.Customers
                .Where(c => c.Id == id)
                .Select(c => new OrderCustomer
                {
                    Id = c.Id,
                    Name = c.Name,
                    Birthday = c.BirthDate,
                    IsYoungDriver = c.IsYoungDriver                    
                })
                .FirstOrDefault();

            return customer;
        }

        public void Edit(int id, string name, DateTime birthday, bool isYoungDriver)
        {
            //bool isYoungDriver = this.IsYoungDriver(birthday);

            var customer = this.dbContext.Customers.FirstOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return;
            }

            customer.Name = name;
            customer.BirthDate = birthday;
            customer.IsYoungDriver = isYoungDriver;

            this.dbContext.SaveChanges();
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
            .Select(c => new 
            {
                Name = c.Name,
                BoughtCarCount = c.Sales.Count,
                CarsSale = c.Sales
                                .Where(s => s.CustomerId == c.Id)                               
                                .Select(cr => new 
                                {
                                    Price = cr.Car.PartCars.Sum(p => (double)p.Part.Price)
                                })
            })
            .FirstOrDefault();

            var sumResult = new CustomerSales()
            {
                Name = result.Name,
                BoughtCarCount = result.BoughtCarCount,
                SpendMoney = result.CarsSale.Sum(a => a.Price)
            };

            return sumResult;
        }

        //later usage
        private bool IsYoungDriver(DateTime birthDay)
        {
            var age = (DateTime.Now - birthDay).Days / 365.25m;
            var experience = age - 18;

            return experience < 2.0m;
        }
    }    
}
