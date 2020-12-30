namespace CarDealer.Web.Services
{
    using CarDealer.Web.Data;
    using CarDealer.Web.Services.DTO.Sales;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesService : ISalesService
    {
        private readonly CarDealerDbContext dbContext;

        public SalesService(CarDealerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public SaleDetailById Detail(int id) =>
            
            this.dbContext.Sales
            .Where(s => s.Id == id)
            .Select(s => new SaleDetailById
            {
                CarMake = s.Car.Make,
                CarModel = s.Car.Model,
                CustomerName = s.Customer.Name
            }).FirstOrDefault();

        public IEnumerable<SaleModel> GetAllSales() =>
            this.dbContext.Sales
            .Select(s => new SaleModel
            {
                SaleId = s.Id,
                Discount = s.Discount + (s.Customer.IsYoungDriver ? 5 : 0),
                CustomerName = s.Customer.Name,
                Make = s.Car.Make,
                Model = s.Car.Model,
                TravelledDistance = s.Car.TravelledDistance,
                TotalPrice = s.Car.PartCars
                                //.Where(pc => pc.CarId == s.CarId)
                                .Sum(pc => pc.Part.Price)                 
            })
            .ToList();

        public IEnumerable<SaleModel> Discounted(double? discount)
        {
            if(discount > 0.00)
            {
                var salesWithSpe = this.dbContext.Sales
                    .Where(s => s.Discount == (decimal)discount)
                    .Select(s => new SaleModel
                    {
                        SaleId = s.Id,
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance,
                        CustomerName = s.Customer.Name,
                        TotalPrice = s.Car.PartCars.Sum(p => p.Part.Price),
                        Discount = s.Discount
                    })                
                .ToList();

                return salesWithSpe;
            }

            var sales = this.dbContext.Sales
                .Select(s => new SaleModel
                {
                    SaleId = s.Id,
                    Make = s.Car.Make,
                    Model = s.Car.Model,
                    TravelledDistance = s.Car.TravelledDistance,
                    CustomerName = s.Customer.Name,
                    TotalPrice = s.Car.PartCars.Sum(p => p.Part.Price),
                    Discount = s.Discount + (s.Customer.IsYoungDriver ? 5 : 0)
                })
                .Where(s => s.Discount > 0)
                .ToList();

            return sales;
        }
    }
}
