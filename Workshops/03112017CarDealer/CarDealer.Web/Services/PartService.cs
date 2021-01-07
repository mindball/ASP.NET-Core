namespace CarDealer.Web.Services
{
    using CarDealer.Web.Data;
    using CarDealer.Web.Services.DTO.Part;
    using System.Collections.Generic;
    using System.Linq;

    public class PartService : IPartService
    {
        
        private readonly CarDealerDbContext dbContext;

        public PartService(CarDealerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int Count()
            => this.dbContext.Parts.Count();

        public IEnumerable<FullPartInfo> GetAllParts(int page = 1, int pageSize = 10)
            => this.dbContext.Parts
                .OrderByDescending(p => p.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new FullPartInfo
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    SupplierName = p.Supplier.Name
                }).ToList();
    }
}
