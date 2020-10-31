namespace GrandBazar.Data.Configurations
{
    using GrandBazar.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> productCategory)
        {
            productCategory
                    .Property(pc => pc.Description)
                    .IsUnicode(true);

            productCategory
                    .Property(pc => pc.Title)
                    .IsUnicode(true);
        }
    }
}
