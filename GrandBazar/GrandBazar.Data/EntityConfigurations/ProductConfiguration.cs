using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
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
