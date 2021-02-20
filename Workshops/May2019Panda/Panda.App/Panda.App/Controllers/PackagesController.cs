namespace Panda.App.Controllers
{
    using AspNetCoreHero.ToastNotification.Abstractions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Panda.App.Common;
    using Panda.App.Models.Package;
    using Panda.Data;
    using Panda.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PackagesController : Controller
    {
        //TODO: replace db context with services
        private readonly PandaDbContext db;
        private readonly INotyfService _notyf;

        public PackagesController(PandaDbContext db, INotyfService _notyf)
        {
            this.db = db;
            this._notyf = _notyf;
        }

        [Authorize(Roles = GlobalConstants.AdminRole)]
        public IActionResult Create()
        {
            this.ViewData["Recipients"] = this.db.Users.ToList();
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Create(PackageCreateBindingModel pckModel)
        {
            var existUser = this.db.Users.Any(u => u.Id == pckModel.Recipient);
            if(!this.ModelState.IsValid || !existUser)
            {
                this.ViewData["Recipients"] = this.db.Users.ToList();
                return this.BadRequest(pckModel);
            }

            var newPackage = new Package
            {
                Description = pckModel.Description,
                Weight = pckModel.Weight,
                ShippingAddress = pckModel.ShippingAddress,
                RecipientId = pckModel.Recipient                
            };

            this.db.Packages.Add(newPackage);

            var result = await this.db.SaveChangesAsync();
            if(result > 0)
            {
                //this.TempData["SuccessMessage"] = $"Created package";
                this._notyf.Success("Created package");
                return this.Redirect("/Home/Index");
            }
            else
            {
                return this.View(pckModel);
            }
        }

        [Authorize(Roles = GlobalConstants.AdminRole)]
        public IActionResult Details(string id)
        {
            var packageDetail = this.db.Packages
                .Where(p => p.Id == id)
                .FirstOrDefault();

            var recipient = this.db.Users
                        .Where(u => u.Id == packageDetail.RecipientId)
                        .Select(q => q.UserName)
                        .FirstOrDefault();
            
            if(packageDetail == null || recipient == null)
            {
                return this.BadRequest("not exit user");
            }

            var result = new PackageCreateBindingModel
            {
                Description = packageDetail.Description,
                ShippingAddress = packageDetail.ShippingAddress,
                PackageStatus = packageDetail.Status.Name,
                EstimatedDeliveryDate = packageDetail.EstimatedDeliveryDate,
                Weight = packageDetail.Weight,
                Recipient = recipient
            };

            return this.View(result);
        }

        public IActionResult Pending()
        {
            var shippedPackige = GetPackingByShipStatus(ShipStatus.Pending);

            return this.View(shippedPackige);
        }

        public async Task<IActionResult> Shipped(string id)
        {
            int randomDay = GenerataRandomDay(GlobalConstants.MinDaysToDelivery,
                GlobalConstants.MaxDaysToDelivery);

            var estimatedDeliveryDate = DateTime.UtcNow.AddDays(randomDay);

            await SetShipStatus(id, ShipStatus.Shipped, estimatedDeliveryDate);

            return this.View(GetPackingByShipStatus(ShipStatus.Shipped));
        }

        private int GenerataRandomDay(int minDaysToDelivery, int maxDaysToDelivery)
        {
            Random r = new Random();
            return r.Next(20, 41);
        }

        private async Task SetShipStatus(string packageId, ShipStatus shipped, DateTime deliveryDate)
        {
            var package = this.db.Packages
               .Where(p => p.Id == packageId).FirstOrDefault();

            if(package == null)
            {
                return;
            }

            package.EstimatedDeliveryDate = deliveryDate;
            package.Status.Name = shipped.ToString();

            this.db.Update(package);

            await this.db.SaveChangesAsync();
        }

        private IEnumerable<PackageCreateBindingModel> GetPackingByShipStatus(ShipStatus status)
            =>  this.db
               .Packages
               .Where(p => p.Status.Name == status.ToString())
               .Select(p => new PackageCreateBindingModel
               {
                   Id = p.Id,
                   Description = p.Description,
                   Weight = p.Weight,
                   EstimatedDeliveryDate = p.EstimatedDeliveryDate,
                   Recipient = p.Recipient.UserName
               })
               .ToList();
        
    }
}
