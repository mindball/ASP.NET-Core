using ApproachWithEmptyMigration.DBContext;
using ApproachWithEmptyMigration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;
using System.Linq;

namespace ApproachWithEmptyMigration.Migrations
{
    public partial class Initial_Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Instantiate new object of DbContext from ConnectionString
            var optionsBuilder = new DbContextOptionsBuilder<SampleDatabaseContext>();
            optionsBuilder.UseSqlServer(GlobalConstant.ConnectionString);

            using (SampleDatabaseContext databaseContext = new SampleDatabaseContext(optionsBuilder.Options))
            {
                databaseContext.LookupTypes.AddRange(
                    new List<LookupType>() {
                        new LookupType()
                            {
                                Name = "ProductTypes",
                                LookupValues = new List<LookupValue>()
                                {
                                    new LookupValue(){ Value="Laptop" },
                                    new LookupValue(){ Value="Monitor" },
                                    new LookupValue(){ Value="Mouse" },
                                    new LookupValue(){ Value="Keyboard" }
                                }
                            }
                    });

                databaseContext.SaveChanges();
            }
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SampleDatabaseContext>();
            optionsBuilder.UseSqlServer(GlobalConstant.ConnectionString);

            using (SampleDatabaseContext databaseContext = new SampleDatabaseContext(optionsBuilder.Options))
            {
                databaseContext.LookupTypes
                    .Remove(databaseContext
                        .LookupTypes
                            .SingleOrDefault(t => t.Name == "ProductTypes"));

                databaseContext.SaveChanges();
            }
        }
    }
}
