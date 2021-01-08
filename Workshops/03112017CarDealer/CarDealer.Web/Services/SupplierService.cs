namespace CarDealer.Web.Services
{
    using CarDealer.Web.Data;
    using CarDealer.Web.Services.DTO.Supplier;
    using System.Collections.Generic;
    using System.Linq;
    public class SupplierService : ISupplierService
    {
        private readonly CarDealerDbContext db;
        public SupplierService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SupplierServiceModel> All()
            => this.db.Suppliers
            .OrderBy(s => s.Name)
            .Select(s => new SupplierServiceModel
            {
                Id = s.Id,
                Name = s.Name
            })
            
            .ToList();

        public IEnumerable<FilteredSupplier> GetSuppliers(bool isImporter) =>
             this.db.Suppliers.Where(s => s.IsImporter == isImporter)
            .Select(s => new FilteredSupplier
            {
                Id = s.Id,
                Name = s.Name,
                NumerOfParts = s.Parts.Count()
            })
            .ToList();
    }
}
