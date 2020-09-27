using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
    public class ProductReviewConfiguration : IEntityTypeConfiguration<ProductReview>
    {
        public void Configure(EntityTypeBuilder<ProductReview> productReview)
        {
            productReview
                    .Property(p => p.Content)
                    .IsUnicode(true);

            productReview
                    .Property(p => p.UserFullName)
                    .IsUnicode(true);

            productReview
                    .Property(p => p.PhoneNumber)
                    .IsUnicode(false);

            productReview
                    .Property(p => p.Email)
                    .IsUnicode(false);

            productReview
                    .HasOne(pr => pr.Product)
                    .WithMany(p => p.ProductReviews)
                    .OnDelete(DeleteBehavior.Restrict);

            productReview
                    .HasOne(pr => pr.User)
                    .WithMany(u => u.ProductReviews)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
