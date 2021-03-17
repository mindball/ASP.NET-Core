using ApproachWithDIMicrosoftVersion.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ApproachWithDIMicrosoftVersion.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
