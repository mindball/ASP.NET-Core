namespace Panda.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Panda.Domain;

    public class ShipStatusSeeder : ISeeder
    {
        //public async Task SeedAsync(PandaDbContext dbContext, IServiceProvider serviceProvider)
        //{
        //    if (dbContext.PackageStatus.Any())
        //    {
        //        return;
        //    }

        //    await dbContext.AddAsync(new PackageStatus { Name = ShipStatus.Pending.ToString() });

        //    await dbContext.SaveChangesAsync();
        //}

        public void Seed(PandaDbContext dbContext)
        {
            if (dbContext.PackageStatus.Any())
            {
                return;
            }

            dbContext.PackageStatus.Add(new PackageStatus { Name = ShipStatus.Pending.ToString() });
            dbContext.PackageStatus.Add(new PackageStatus { Name = ShipStatus.Shipped.ToString() });
            dbContext.PackageStatus.Add(new PackageStatus { Name = ShipStatus.Delivered.ToString() });
            dbContext.PackageStatus.Add(new PackageStatus { Name = ShipStatus.Acquired.ToString() });
            //await dbContext.AddAsync(new PackageStatus { Name = ShipStatus.Pending.ToString() });

            dbContext.SaveChanges();
        }
    }
}
