using Microsoft.EntityFrameworkCore;

namespace api_ng_superhero.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }

       public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();


    }
}
