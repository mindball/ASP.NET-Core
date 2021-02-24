namespace Panda.App.Controllers
{
    using AspNetCoreHero.ToastNotification.Abstractions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Panda.App.Common;
    using Panda.App.Models.Package;
    using Panda.Data;
    using Panda.Domain;
    using System.Globalization;
    using System.Security.Claims;

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
                
        public IActionResult Index()
        {
            if(this.User.Identity.IsAuthenticated)
            {
                var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

                List<PackageHomeViewModel> packages = null;
                if (this.User.IsInRole(GlobalConstants.AdminRole))
                {
                    packages = GetPackages(userId, true);
                    return this.View(packages);
                }

                packages = GetPackages(userId);

                return this.View(packages);
            }

            return this.View();
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
            string setDefaultShipStatusId = GetShipStatusId(ShipStatus.Pending);

            if (!this.ModelState.IsValid ||
                !existUser ||
                setDefaultShipStatusId == null)
            {
                this.ViewData["Recipients"] = this.db.Users.ToList();
                return this.BadRequest(pckModel);
            }

            var newPackage = new Package
            {
                Description = pckModel.Description,
                Weight = pckModel.Weight,
                ShippingAddress = pckModel.ShippingAddress,
                RecipientId = pckModel.Recipient,
                StatusId = setDefaultShipStatusId
            };
            
            CreateReceipt(pckModel, newPackage);

            this.db.Packages.Add(newPackage);            

            var result = await this.db.SaveChangesAsync();
            if (result > 0)
            {
                //this.TempData["SuccessMessage"] = $"Created package";
                this._notyf.Success("Created package");
                return this.Redirect("/Packages/Index");
            }
            else
            {
                return this.View(pckModel);
            }
        }       

        [Authorize]
        public IActionResult Details(string id)
        {
            var packageDetail = this.db.Packages
                .Where(p => p.Id == id)
                .FirstOrDefault();

            var recipient = this.db.Users
                        .Where(u => u.Id == packageDetail.RecipientId)
                        .Select(q => q.UserName)
                        .FirstOrDefault();

            if (packageDetail == null || recipient == null)
            {
                return this.BadRequest("not exit user");
            }

            var dateFormat = packageDetail.EstimatedDeliveryDate != null
                ? packageDetail.EstimatedDeliveryDate.Value.ToShortTimeString() : null;

            var shipStatus = GetShipStatusName(packageDetail.StatusId);

            var result = new PackageDetailedBindingModel
            {
                Description = packageDetail.Description,
                ShippingAddress = packageDetail.ShippingAddress,
                PackageStatus = shipStatus,
                EstimatedDeliveryDate = dateFormat,
                Weight = packageDetail.Weight,
                Recipient = recipient
            };

            ////If the package’s status is Delivered or Acquired, instead of the date, 
            ////“Delivered” should be presented.
            if ((packageDetail.Status.Name == ShipStatus.Delivered.ToString()
                || packageDetail.Status.Name == ShipStatus.Acquired.ToString())
                && packageDetail.EstimatedDeliveryDate == null)
            {
                result.PackageStatus = ShipStatus.Acquired.ToString();
                result.EstimatedDeliveryDate = packageDetail.Status.Name;
            }

            return this.View(result);
        }

        [Authorize]
        public IActionResult Pending()
        {
            var shippedPackage = GetPackingByShipStatus(ShipStatus.Pending);

            return this.View(shippedPackage);
        }

        [Authorize]
        public async Task<IActionResult> Shipped(string id)
        {
            var statusId = GetShipStatusId(ShipStatus.Shipped);

            int randomDay = GenerataRandomDay(GlobalConstants.MinDaysToDelivery,
                GlobalConstants.MaxDaysToDelivery);

            var estimatedDeliveryDate = DateTime.UtcNow.AddDays(randomDay).ToString("d");//, CultureInfo.CreateSpecificCulture("es-ES"));

            await SetShipStatus(id, statusId, estimatedDeliveryDate);

            //return this.View(viewModel, "Shipped");
            return this.RedirectToAction(nameof(ShippedAll));
        }

        [Authorize]
        public IActionResult ShippedAll()
        {
            var viewModel = GetPackingByShipStatus(ShipStatus.Shipped);

            return this.View(viewModel);
        }

        [Authorize]
        public async Task<IActionResult> Delivered(string id)
        {
            var statusId = GetShipStatusId(ShipStatus.Delivered);

            await SetShipStatus(id, statusId, null);

            return this.RedirectToAction(nameof(DeliveredAll));
        }
                
        [Authorize]
        public IActionResult DeliveredAll()
        {
            var viewModel = GetPackingByShipStatus(ShipStatus.Delivered);

            return this.View(viewModel);
        }

        private string GetShipStatusId(ShipStatus statusName)
            => this.db.PackageStatus
                          .Where(p => p.Name == statusName.ToString())
                          .Select(p => p.Id)
                          .FirstOrDefault();

        private int GenerataRandomDay(int minDaysToDelivery, int maxDaysToDelivery)
        {
            Random r = new Random();
            return r.Next(20, 41);
        }

        private async Task SetShipStatus(string packageId, string statusId, string deliveryDate)
        {
            var package = this.db.Packages
               .Where(p => p.Id == packageId).FirstOrDefault();

            var status = this.db.PackageStatus
                .Where(ps => ps.Id == statusId)
                .Select(ps => ps.Id)
                .FirstOrDefault();

            if (package == null || status == null)
            {
                return;
            }

            //ToString("d", CultureInfo.CreateSpecificCulture("es-ES"));
            if (deliveryDate != null)
            {
                package.EstimatedDeliveryDate =
                    DateTime.Parse(deliveryDate, CultureInfo.CreateSpecificCulture("es-ES"));
            }
            else
            {
                package.EstimatedDeliveryDate = null;
            }

            package.StatusId = status;

            this.db.Update(package);
            await this.db.SaveChangesAsync();
        }

        private IEnumerable<PackageCreateBindingModel> GetPackingByShipStatus(ShipStatus status)
            => this.db
               .Packages
               .Where(p => p.Status.Name == status.ToString())
               .Select(p => new PackageCreateBindingModel
               {
                   Id = p.Id,
                   Description = p.Description,
                   Weight = p.Weight,
                   EstimatedDeliveryDate = p.EstimatedDeliveryDate,
                   Recipient = p.Recipient.UserName,
                   ShippingAddress = p.ShippingAddress
               })
               .ToList();

        private string GetShipStatusName(string id = null, string shipStatusName = null)
        {
            if (id == null && shipStatusName == null)
            {
                return null;
            }

            if (id != null)
            {
                var pckStatusById = this.db.PackageStatus
                    .Where(ps => ps.Id == id)                    
                    .FirstOrDefault();

                return pckStatusById.Name;
            }

            var pckStatusByName = this.db.PackageStatus
                    .Where(ps => ps.Name == shipStatusName)                    
                    .FirstOrDefault();

            return pckStatusByName.Name;
        }

        private void CreateReceipt(PackageCreateBindingModel pckModel, Package newPackage)
        {
            var newReceipt = new Receipt
            {
                Fee = (decimal)(pckModel.Weight * 2.67),
                IssuedOn = DateTime.UtcNow,
                RecipientId = pckModel.Recipient,
                PackageId = newPackage.Id
            };

            this.db.Receipts.Add(newReceipt);
        }

        private List<PackageHomeViewModel> GetPackages(string userClaim, bool isAdmin = false)
        {
            var packages = this.db.Packages
                .Select(r => new PackageHomeViewModel
                {
                    Id = r.Id,
                    Description = r.Description,
                    Status = r.Status.Name,
                    UserId = r.RecipientId
                });

            if (isAdmin)
            {
                var allAPackages = packages.ToList();
                return allAPackages;
            }

            var allUserPackages = packages
                .Where(r => r.UserId == userClaim)
                .ToList();

            return allUserPackages;
        }
    }
}
