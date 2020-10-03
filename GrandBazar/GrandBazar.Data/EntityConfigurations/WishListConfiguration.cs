using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
    public class WishListConfiguration : IEntityTypeConfiguration<WishList>
    {
        public void Configure(EntityTypeBuilder<WishList> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.UserId });

            builder
                .HasOne(x => x.Product)
                .WithMany(y => y.WishLists)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.User)
                .WithMany(y => y.WishLists)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
