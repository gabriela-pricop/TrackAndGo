using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Infrastructure.Data.EntityConfigurations
{
    public class PointOfInterestHotelConfiguration : IEntityTypeConfiguration<PointOfInterestHotel>
    {
        public void Configure(EntityTypeBuilder<PointOfInterestHotel> builder)
        {
            builder.HasOne(x => x.Hotel)
                .WithMany(x => x.PointOfInterestHotels)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.PointOfInterest)
                .WithMany(x => x.PointOfInterestHotels)
                .HasForeignKey(x => x.PointOfInterestId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Distance).IsRequired();
            //pentru campurile value type nu e obligatoriu sa pui is required, este by default
            //la string trebuie numaidecat
        }
    }
}
