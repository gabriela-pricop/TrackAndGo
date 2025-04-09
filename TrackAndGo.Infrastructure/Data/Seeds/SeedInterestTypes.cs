using Microsoft.EntityFrameworkCore;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Infrastructure.Data.Seeds
{
    public static class SeedInterestTypes
    {
        private static readonly List<InterestType> InterestTypes = new()
        {
            new InterestType { Id = 1, Name = "Monastery" },
            new InterestType { Id = 2, Name = "Hiking" },
            new InterestType { Id = 3, Name = "Sight-seeing"},
            new InterestType { Id = 4, Name = "Fortress" },
            new InterestType { Id = 5, Name = "Castle" },
            new InterestType { Id = 6, Name = "Winery" },
            new InterestType { Id = 7, Name = "Caving" },
            new InterestType { Id = 8, Name = "Nature reserve" },
            new InterestType { Id = 9, Name = "Entertainment" },
            new InterestType { Id = 10, Name = "Museum" },
            new InterestType { Id = 11, Name = "Farm" },
            new InterestType { Id = 12, Name = "Zoo"},
            new InterestType { Id = 13, Name = "Lake" }
        };
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InterestType>().HasData(InterestTypes);
        }
    }
}
