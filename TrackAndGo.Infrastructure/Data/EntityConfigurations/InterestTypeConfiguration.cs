using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Infrastructure.Data.EntityConfigurations
{
    internal class InterestTypeConfiguration : IEntityTypeConfiguration<InterestType>
    {
        public void Configure(EntityTypeBuilder<InterestType> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

            builder.HasMany(x => x.PointOfInterests)
                .WithOne(x => x.InterestType)
                .HasForeignKey(x => x.InterestTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
