using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Infrastructure.Data.EntityConfigurations
{
    public class PointOfInterestConfiguration : IEntityTypeConfiguration<PointOfInterest>
    {
        public void Configure(EntityTypeBuilder<PointOfInterest> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.ImageUrl).HasMaxLength(500).IsRequired();
            builder.Property(x => x.WebsiteUrl).HasMaxLength(500);
            builder.Property(x => x.Latitude).HasColumnType("decimal(9,6)").IsRequired();
            builder.Property(x => x.Longitude).HasColumnType("decimal(9,6)").IsRequired();

            builder.HasOne(x => x.InterestType)
                .WithMany(x => x.PointOfInterests)
                .HasForeignKey(x => x.InterestTypeId) //de la navigational property inapoi
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.City)
                .WithMany(x => x.PointOfInterests)
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Images)
                .WithOne(x => x.PointOfInterest)
                .HasForeignKey(x => x.PointOfInterestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.PointOfInterestHotels)
                .WithOne(x => x.PointOfInterest)
                .HasForeignKey(x => x.PointOfInterestId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
