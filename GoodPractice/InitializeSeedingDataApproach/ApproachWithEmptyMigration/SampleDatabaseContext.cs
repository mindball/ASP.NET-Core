using ApproachWithEmptyMigration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ApproachWithEmptyMigration.DBContext
{
    public class SampleDatabaseContext : DbContext
    {
        public SampleDatabaseContext() : base() { }

        public SampleDatabaseContext(DbContextOptions<SampleDatabaseContext> options) 
            : base(options) { }

        public virtual DbSet<LookupType> LookupTypes { get; set; }
        public virtual DbSet<LookupValue> LookupValues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opBuilder)
        {
            if (!opBuilder.IsConfigured)
            {
                opBuilder.UseSqlServer(GlobalConstant.ConnectionString);
            }
        }
    }
}
