namespace GrandBazar.Data.Configurations
{
    using GrandBazar.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
