namespace Panda.App.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Panda.App.Common;
    using Panda.App.Models.Receipts;
    using Panda.Data;
    using Panda.Domain;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Globalization;

    public class ReceiptsController : Controller
    {
        private readonly PandaDbContext db;
        private readonly UserManager<PandaUser> userManager;

        public ReceiptsController(PandaDbContext db,
            UserManager<PandaUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }
        
        [Authorize]
        public IActionResult Index()
        {
            //get user id
            var userClaim = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (userClaim == null)
            {
                return this.BadRequest("not exist user");
            }
            
            if(this.User.IsInRole(GlobalConstants.AdminRole))
            {
                var allReceipts = GetReceipts(userClaim, true);
                return this.View(allReceipts);
            }

            var userReceipts = GetReceipts(userClaim);

            return this.View(userReceipts);
        }
        
        [Authorize]
        public IActionResult Details(string id)
        {
            var relatedReceiptData = this.db
                .Receipts
                .Where(r => r.Id == id)
                .Include(p => p.Package)
                .Include(p => p.Recipient)
                .SingleOrDefault();

            var receiptDetail = new ReceiptDetailViewModel
                {
                    Id = relatedReceiptData.Id,
                    IssuedOn = relatedReceiptData.IssuedOn.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Fee = relatedReceiptData.Fee,
                    DeliveryAddress = relatedReceiptData.Package.ShippingAddress,
                    RecipientName = relatedReceiptData.Recipient.UserName,
                    Weight = relatedReceiptData.Package.Weight,
                    Description = relatedReceiptData.Package.Description
                };                

            return this.View(receiptDetail);
        }

        //Deferred execution of query
        private List<ReceiptViewModel> GetReceipts(string userClaim, bool isAdmin = false)
        {
            var receipts = this.db.Receipts
                .Select(r => new ReceiptViewModel
                {
                    Id = r.Id,
                    Fee = r.Fee,
                    IssuedOn = r.IssuedOn.ToShortDateString(),
                    RecipientName = r.Recipient.UserName,
                    RecipientId = r.RecipientId
                });

            if(isAdmin)
            {
                var allReceipts = receipts.ToList();
                return allReceipts;
            }

            var userReceipts = receipts
                .Where(r => r.RecipientId == userClaim)
                .ToList();

            return userReceipts;
        }
    }
}
