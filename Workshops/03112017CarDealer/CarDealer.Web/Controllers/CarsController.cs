namespace CarDealer.Web.Controllers
{
    using CarDealer.Web.Models.Cars;
    using CarDealer.Web.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("cars")]
    public class CarsController : Controller
    {
        private readonly ICarService carService;

        public CarsController(ICarService carService)
        {
            this.carService = carService;
        }

        [Route("{make}", Order = 2)]
        public IActionResult ByMake(string make)
        {
            var carResult = this.carService.GetMakedCar(make.ToLower());

            var cars = new CarsByMakeViewModel
            {
                CarsByMake = carResult,
                Maker = make
            };

            return this.View(cars);
        }

        [Route("parts", Order = 1)]
        public IActionResult Parts()
        {
            var result = this.carService.GetCarsWithParts();

            return this.View(result);
        }

    }
}
