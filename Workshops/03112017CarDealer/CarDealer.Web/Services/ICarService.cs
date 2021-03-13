namespace CarDealer.Web.Services
{
    using CarDealer.Web.Services.DTO.Car;
    using System.Collections.Generic;

    public interface ICarService
    {
        IEnumerable<FullDetailCarSericeModel> GetFullDetailCar(string make);

        IEnumerable<CarWithParts> GetCarsWithParts();

        IEnumerable<CarMakeServiceModel> GetCarMake();

        void Create(string make, string model, long travelledDistance, IEnumerable<int> partsId);

        IEnumerable<FullDetailCarSericeModel> GetAllCars(int pageNumber, int pageSize);

        int Count();
    }
}
