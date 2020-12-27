using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Web.Models.Cars;
using CarDealer.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Web.Controllers
{
    [Route("cars")]
    public class CarsController : Controller
    {
        private readonly ICarService carService;

        public CarsController(ICarService carService)
        {
            this.carService = carService;
        }

        [Route("{make}")]
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
    }
}
