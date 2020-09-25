using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
    public class OrderProductsConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        //TODO: Implement
        public void Configure(EntityTypeBuilder<OrderProduct> orderPrdouct)
        {
            orderPrdouct.HasKey(op => new { op.OrderId, op.ProductId });

            orderPrdouct
                    .HasOne(op => op.Order)
                    .WithMany(o => o.OrderProducts)
                    .OnDelete(DeleteBehavior.Restrict);

            orderPrdouct
                    .HasOne(op => op.Product)
                    .WithMany(p => p.OrderProducts)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
