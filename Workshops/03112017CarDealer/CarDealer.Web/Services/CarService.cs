
namespace CarDealer.Web.Services
{
    using CarDealer.Web.Data;
    using CarDealer.Web.Services.DTO.Car;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CarService : ICarService
    {

        private readonly CarDealerDbContext dbContext;

        public CarService(CarDealerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<CarMaked> GetMakedCar(string make) =>
            this.dbContext.Cars
            .Where(c => c.Make.ToLower() == make)
            .Select(c => new CarMaked
            {
                Id = c.Id,
                Make = c.Make,
                Model = c.Model,
                TravelledDistance = c.TravelledDistance
            })
            .OrderBy(c => c.Model)
            .ThenByDescending(c => c.TravelledDistance)
            .ToList();        
    }
}
