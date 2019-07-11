using Microsoft.EntityFrameworkCore;


namespace MCSeeds.models
{
    public class MCSeedContext:DbContext
    {
        public MCSeedContext(DbContextOptions<MCSeedContext> options):base(options)
        {

        }
              public DbSet<seed> Seeds {get; set;}
    }
}