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

        public void Create(string name, decimal price, int quantity, int supplierId) 
        {
            var newPart = new Part
            {
                Name = name,
                Price = price,
                Quantity = quantity,
                SupplierId = supplierId
            };

            this.dbContext.Parts.Add(newPart);
            this.dbContext.SaveChanges();
        }


        public void Destroy(int id)
        {
            var part = this.dbContext.Parts.FirstOrDefault(s => s.Id == id);

            if(part == null)
            {
                return;
            }

            this.dbContext.Parts.Remove(part);
            this.dbContext.SaveChanges();
        }

        public void EditPart(int id, decimal price, int quantity)
        {
            var partToEdit = this.dbContext.Parts.Find(id);

            if(partToEdit == null)
            {
                return;
            }

            partToEdit.Price = price;
            partToEdit.Quantity = quantity;

            this.dbContext.SaveChanges();
        }

        public EditPartServiceModel GetPartById(int id)
        {
            var partById = this.dbContext.Parts
                .Where(p => p.Id == id)
                .Select(p => new EditPartServiceModel
                {
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity
                })
                .FirstOrDefault();

            if(partById == null)
            {
                return null;
            }

            return partById;
        }
    }
}
