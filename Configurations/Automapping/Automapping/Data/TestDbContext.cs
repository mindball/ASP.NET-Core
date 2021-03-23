using Microsoft.EntityFrameworkCore;

namespace Automapping.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Passport> Passports { get; set; }

        public DbSet<Person> Persons { get; set; }
    }

    
}
