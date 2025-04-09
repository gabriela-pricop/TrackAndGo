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
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            //continut
            //configurari pentru a pune limite pentru fiecrae field
            //de exemplu nr telefon 15 caractere
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired(); // se creeaza in baza o restrictie pentru denumirea hotel 
            builder.Property(x => x.Phone).HasMaxLength(15).IsRequired();// in Moldova nu trebuie mai mult
            //buna practica de adugat relatiile si aici, chiar daca ar trebuie sa inteleaga cu navigationla properties
            builder.HasMany(x => x.PointOfInterestHotels).WithOne(x => x.Hotel); //legatura, lucreaza prin navigationla properties
            builder.Property(x => x.Latitude).HasColumnType("decimal(9,6)").IsRequired();
            builder.Property(x => x.Longitude).HasColumnType("decimal(9,6)").IsRequired();
        }
    }
}
