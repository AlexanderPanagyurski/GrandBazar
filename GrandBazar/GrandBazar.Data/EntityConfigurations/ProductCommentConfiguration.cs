﻿using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
    public class ProductCommentConfiguration : IEntityTypeConfiguration<ProductComment>
    {
        public void Configure(EntityTypeBuilder<ProductComment> productComment)
        {
            productComment
                    .Property(pc => pc.Content)
                    .IsUnicode(true);

            productComment
                    .Property(pc => pc.PhoneNumber)
                    .IsUnicode(false);

            productComment
                    .Property(pc => pc.Email)
                    .IsUnicode(false);

            productComment
                    .HasOne(pc => pc.Product)
                    .WithMany(p => p.ProductComments)
                    .OnDelete(DeleteBehavior.Restrict);

            productComment
                    .HasOne(pc => pc.User)
                    .WithMany(u => u.ProductComments)
                    .OnDelete(DeleteBehavior.Restrict);

            productComment
                .HasOne(x => x.ParentComment)
                .WithMany(y => y.CommentReplies)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
