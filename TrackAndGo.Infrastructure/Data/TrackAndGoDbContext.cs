using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrackAndGo.Domain.Entities;
using TrackAndGo.Infrastructure.Data.Seeds;

namespace TrackAndGo.Infrastructure.Data
{
    public class TrackAndGoDbContext : DbContext
    {
        //comanda de a genera
        //add-migration Init -Context TrackAndGoDbContext -OutputDir Data/Migrations
        //in init une de fiecare data altceva
        public TrackAndGoDbContext() 
        {

        }
        public TrackAndGoDbContext(DbContextOptions<TrackAndGoDbContext> options)
            : base(options) { }

        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<InterestImage> InterestImages { get; set; }
        public DbSet<InterestType> InterestTypes { get; set; }
        public DbSet<PointOfInterest> PointOfInterests { get; set; }
        public DbSet<PointOfInterestHotel> PointOfInterestHotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //ii spunem sa aplice fisierele de configurari
            //seed
            //configurari generale

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedDistricts.Seed(modelBuilder); //static nu trebuie sa creem obiect
            SeedCities.Seed(modelBuilder);
            SeedInterestTypes.Seed(modelBuilder);
        }
    }
}
