using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
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
