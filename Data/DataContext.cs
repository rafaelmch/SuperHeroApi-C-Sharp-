// Rafael Hassegawa - 16/02/2024
// Storing data in a database
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI_DotNet8.Entity;

namespace SuperHeroAPI_DotNet8.Data
{
    public class DataContext : DbContext
    {
        // constructor ctro
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        // property (prop)
        public DbSet<SuperHero> SuperHeroes { get; set; }

    }
}
