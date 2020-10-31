namespace GrandBazar.Data.Configurations
{
    using GrandBazar.Data.Common.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
