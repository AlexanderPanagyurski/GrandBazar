namespace GrandBazar.Data.Configurations
{
    using GrandBazar.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> order)
        {
            order
                .Property(o => o.AdditionalInformation)
                .IsUnicode(true);

            order
                .Property(o => o.Email)
                .IsUnicode(false);

            order
                .Property(o => o.ZipCode)
                .IsUnicode(false);

            order
                .Property(o => o.PhoneNumber)
                .IsUnicode(false);

            order
                .Property(o => o.Address)
                .IsUnicode(true);

            order
                .Property(o => o.City)
                .IsUnicode(true);

            order
                .Property(o => o.FirstName)
                .IsUnicode(true);

            order
                .Property(o => o.LastName)
                .IsUnicode(true);
        }
    }
}
