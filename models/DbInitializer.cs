using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MCSeeds.models
{
    public static class DbInitializer
    {
        public static void Initialize(MCSeedContext Context)
        {
            if (Context.Seeds.Any())
            {
                return;
            }

            var seeds = new seed[]{
                new seed{SeedValue = "0123456789",SeedText="random seed",Description = "a pretty place",Title="First Seed",ImageID = "0", versionID = "0"},
                new seed{SeedValue = "0000000000",SeedText="random seed",Description = "a prettier place",Title="Second Seed",ImageID = "0", versionID = "0"}
        };
        foreach (seed item in seeds)
        {
            Context.Add(item);
        }
        Context.SaveChanges();
        }
    }
}
