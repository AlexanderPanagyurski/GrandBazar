using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> city)
        {
            city
                .Property(c => c.Name)
                .IsUnicode(true);

            city
                .HasOne(c => c.Country)
                .WithMany(x => x.Cities)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
