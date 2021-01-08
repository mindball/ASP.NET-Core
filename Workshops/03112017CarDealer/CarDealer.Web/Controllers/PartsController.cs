namespace CarDealer.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarDealer.Web.Models.Parts;
    using CarDealer.Web.Models.Suppliers;
    using CarDealer.Web.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class PartsController : Controller
    {
        private const int PageSize = 25;
        private readonly IPartService partService;
        private readonly ISupplierService supplierService;

        public PartsController(IPartService partService,
            ISupplierService supplierService)
        {
            this.partService = partService;
            this.supplierService = supplierService;
        }

        public IActionResult Index(int page = 1)
            => this.View(new PartPageListingViewModel
            {
                Parts = this.partService.GetAllParts(page, PageSize),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(this.partService.Count() / (double)PageSize)
            });


        public IActionResult Edit(int id)
        {
            var partToEdit = this.partService.GetPartById(id);

            if(partToEdit == null)
            {
                return NotFound();
            }

            return this.View(new PartFormViewModel
            { 
                Name = partToEdit.Name,
                Price = partToEdit.Price,
                Quantity = partToEdit.Quantity,
                IsEdit = true
            });
        }

        [Route("parts/edit" + "/{id}")]
        [HttpPost]
        public IActionResult Edit(int id, PartFormViewModel partModel)
        {
            if (!ModelState.IsValid)
            {
                partModel.IsEdit = true;
                return this.View(partModel);
            }

            this.partService.EditPart(id, partModel.Price, partModel.Quantity);

            return this.RedirectToAction(nameof(Index));
        }

            public IActionResult Delete(int id)
        {    
            return this.View(id);
        }

        public IActionResult Destroy(int id)
        {
            this.partService.Destroy(id);

            return this.RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            var partModel = new PartFormViewModel();
            partModel.AllSuppliers = this.supplierService.All()
                .Select(s => new SupplierViewModel
                {
                    Id = s.Id,
                    Name = s.Name
                });

            //Kenov version
            var parrModelKenov = new PartFormViewModel
            {
                AllSuppliersKenovVersion =
                    GetSupplierListItems()
            };

            return this.View(parrModelKenov);
            //return this.View(partModel);
        }

        [HttpPost]
        public IActionResult Create(PartFormViewModel createPart)
        {
            if (createPart == null || !ModelState.IsValid)
            {
                createPart.AllSuppliersKenovVersion = GetSupplierListItems();
                return View(createPart);
            }

            this.partService.Create(createPart.Name, 
                createPart.Price, 
                createPart.Quantity, 
                createPart.SupplierId);

            return this.RedirectToAction(nameof(Index));            
        }

        private IEnumerable<SelectListItem> GetSupplierListItems()
        {
            return this.supplierService
                    .All()
                    .Select(s => new SelectListItem
                    {
                        Text = s.Name,
                        Value = s.Id.ToString()
                    });
        }
    }
}
