namespace CarDealer.Web.Services
{
    using CarDealer.Web.Data;
    using CarDealer.Web.Services.DTO.Car;
    using CarDealer.Web.Services.DTO.Part;

    using System.Collections.Generic;
    using System.Linq;

    public class CarService : ICarService
    {

        private readonly CarDealerDbContext dbContext;

        public CarService(CarDealerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<CarWithParts> GetCarsWithParts() =>
            this.dbContext.Cars
            .Select(c => new CarWithParts
            {
                Id = c.Id,
                CarMake = c.Make,
                Model = c.Model,
                TravelledDistance = c.TravelledDistance,
                Parts = c.PartCars.Select(pc => new PartInfo
                {
                    Name = pc.Part.Name,
                    Price = pc.Part.Price
                })
            })
            .ToList();
        
        public IEnumerable<FullDetailCarSericeModel> GetFullDetailCar(string make) =>
            this.dbContext.Cars
            .Where(c => c.Make.ToLower() == make)
            .Select(c => new FullDetailCarSericeModel
            {
                Id = c.Id,
                CarMake = c.Make,
                Model = c.Model,
                TravelledDistance = c.TravelledDistance
            })
            .OrderByDescending(c => c.Id)
            .ThenByDescending(c => c.TravelledDistance)
            .ToList();

        public IEnumerable<CarMakeServiceModel> GetCarMake()
            => this.dbContext.Cars
            .Select(c => new CarMakeServiceModel
            {
                CarMake = c.Make
            })
            .Distinct()
            .ToList();

        public void Create(string make, string model, long travelledDistance)
        {
            var newCar = new Car
            {
                Make = make,
                Model = model,
                TravelledDistance = travelledDistance
            };

            this.dbContext.Cars.Add(newCar);

            this.dbContext.SaveChanges();
        }

        public IEnumerable<FullDetailCarSericeModel> GetAllCars(int pageNumber = 1, int pageSize = 10)
            => this.dbContext.Cars
                .OrderByDescending(p => p.Id)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(c => new FullDetailCarSericeModel
                {
                    Id = c.Id,
                    CarMake = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })           
            .ToList();

        public int Count()
            => this.dbContext.Cars.Count();
    }

    
}
