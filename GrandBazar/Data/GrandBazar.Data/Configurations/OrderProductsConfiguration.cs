namespace GrandBazar.Data.Configurations
{
    using GrandBazar.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OrderProductsConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
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
