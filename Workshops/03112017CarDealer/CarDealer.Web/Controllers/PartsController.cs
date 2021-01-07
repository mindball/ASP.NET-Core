namespace CarDealer.Web.Controllers
{
    using CarDealer.Web.Models.Parts;
    using CarDealer.Web.Services;
    using Microsoft.AspNetCore.Mvc;
    using System;

    public class PartsController : Controller
    {
        private const int PageSize = 25;
        private readonly IPartService partService;

        public PartsController(IPartService partService)
        {
            this.partService = partService;
        }

        public IActionResult Index(int page = 1)
            => this.View(new PartPageListingViewModel
            {
                Parts = this.partService.GetAllParts(page, PageSize),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(this.partService.Count() / (double)PageSize)
            });


        public IActionResult Edit(int partId, int supplierId)
        {

            return this.View();
        }
    }
}
