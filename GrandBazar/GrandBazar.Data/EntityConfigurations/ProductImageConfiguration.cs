using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> productImage)
        {
            productImage
                    .Property(pi => pi.Name)
                    .IsUnicode(true);

            productImage
                    .HasOne(pi => pi.Product)
                    .WithMany(p => p.ProductImages)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
