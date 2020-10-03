using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
    public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> shoppingCart)
        {

            shoppingCart.HasKey(x => new { x.ProductId, x.UserId });

            shoppingCart
                .HasOne(x => x.Product)
                .WithMany(y => y.ShoppingCarts)
                .OnDelete(DeleteBehavior.Restrict);

            shoppingCart
                .HasOne(x => x.User)
                .WithMany(y => y.ShoppingCarts)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
