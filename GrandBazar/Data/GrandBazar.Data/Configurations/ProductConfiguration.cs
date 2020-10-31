namespace GrandBazar.Data.Configurations
{
    using GrandBazar.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> product)
        {
            product
                .Property(p => p.Name)
                .IsUnicode(true);

            product
                .HasOne(p => p.ProductCategory)
                .WithMany(pc => pc.Products)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
