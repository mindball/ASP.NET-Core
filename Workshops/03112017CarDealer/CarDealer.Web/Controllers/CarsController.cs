namespace CarDealer.Web.Controllers
{
    using CarDealer.Web.Models.Cars;
    using CarDealer.Web.Services;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Authorization;

    public class CarsController : Controller
    {
        private const int PageSize = 25;
        private const int defaulPage = 1;
        private readonly ICarService carService;
        private readonly IPartService partService;

       
        public CarsController(ICarService carService, IPartService partService)
        {
            this.carService = carService;
            this.partService = partService;
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
        [Authorize]
        public IActionResult Create()
            => this.View(new CarFormViewModel
            {
                AllParts = this.GetPartListItems()
            });

        [HttpPost]
        [Authorize]
        public IActionResult Create(CarFormViewModel carViewModel)
        {
            if (carViewModel == null || !ModelState.IsValid)
            {
                carViewModel.AllParts = this.GetPartListItems();
                return this.View(carViewModel);
            }

            this.carService
                .Create(carViewModel.Make
                , carViewModel.Model
                , carViewModel.TravelledDistance
                , carViewModel.SelectedParts);

            return this.RedirectToAction(nameof(this.Index));
        }

        private IEnumerable<SelectListItem> GetPartListItems()
           => partService
                    .All()
                    .Select(s => new SelectListItem
                    {
                        Text = s.Name,
                        Value = s.Id.ToString()
                    })
            .ToList();
        
    }
}
