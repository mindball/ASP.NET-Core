using CarDealer.Web.Data;
using CarDealer.Web.Services.DTO.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly CarDealerDbContext db;
        public SupplierService(CarDealerDbContext db)
        {
            this.db = db;
        }
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
