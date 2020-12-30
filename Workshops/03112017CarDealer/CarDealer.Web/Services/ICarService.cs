namespace CarDealer.Web.Services
{
    using CarDealer.Web.Services.DTO.Car;
    using System.Collections.Generic;

    public interface ICarService
    {
        IEnumerable<CarMaked> GetMakedCar(string make);

        IEnumerable<CarWithParts> GetCarsWithParts();
    }
}
