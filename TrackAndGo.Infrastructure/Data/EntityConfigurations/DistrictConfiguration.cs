using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Infrastructure.Data.EntityConfigurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

            builder.HasMany(x => x.Cities)
                .WithOne(x => x.District)
                .HasForeignKey(x => x.DistrictId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
