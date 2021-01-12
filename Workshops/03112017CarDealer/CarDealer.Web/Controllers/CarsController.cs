namespace CarDealer.Web.Controllers
{
    using CarDealer.Web.Models.Cars;
    using CarDealer.Web.Services;
    using Microsoft.AspNetCore.Mvc;
    using System;
  
    public class CarsController : Controller
    {
        private const int PageSize = 25;
        private const int defaulPage = 1;
        private readonly ICarService carService;

        public CarsController(ICarService carService)
        {
            this.carService = carService;
        }

        
        public IActionResult Index(int page = defaulPage)
            
            => this.View(new CarPageListiningViewModel
            {
                Cars = this.carService.GetAllCars(page, PageSize),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(this.carService.Count() / (double)PageSize)
            });

        [Route("cars/bymake" + "/{make}")]
        public IActionResult ByMake(string make)
        {
            var carResult = this.carService.GetFullDetailCar(make.ToLower());

            var cars = new CarsByMakeViewModel
            {
                CarsByMake = carResult,
                Maker = make
            };

            return this.View(cars);
        }
        
        public IActionResult Parts()
        {
            var result = this.carService.GetCarsWithParts();

            return this.View(result);
        }

        [HttpGet]        
        public IActionResult Create()
            => this.View();

        [HttpPost]        
        public IActionResult Create(CarFormViewModel carViewModel)
        {
            if (carViewModel == null || !ModelState.IsValid)
            {
                return this.View(carViewModel);
            }

            this.carService.Create(carViewModel.Make, carViewModel.Model, carViewModel.TravelledDistance);

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
