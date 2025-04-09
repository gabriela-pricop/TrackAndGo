using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Infrastructure.Data.EntityConfigurations
{
    public class InterestImageConfiguration : IEntityTypeConfiguration<InterestImage>
    {
        public void Configure(EntityTypeBuilder<InterestImage> builder)
        {
            builder.Property(x => x.ImageUrl).HasMaxLength(500).IsRequired();

            builder.HasOne(x => x.PointOfInterest)
                .WithMany(x => x.Images)
                .HasForeignKey(x => x.PointOfInterestId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
