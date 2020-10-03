using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            user
                .Property(u => u.FirstName)
                .IsUnicode(true);
            user
                .Property(u => u.LastName)
                .IsUnicode(true);
            user
                .Property(u => u.AboutMe)
                .IsUnicode(true);

            user
                .Property(u => u.Email)
                .IsUnicode(false);

            user
                .Property(u => u.PhoneNumber)
                .IsUnicode(false);

            user
                .Property(u => u.ImageUrl)
                .IsUnicode(false);

            user
                .Property(u => u.CoverImageUrl)
                .IsUnicode(false);

            user
                .Property(u => u.InstagramUrl)
                .IsUnicode(false);

            user
                .Property(u => u.TwitterUrl)
                .IsUnicode(false);

            user
                .Property(u => u.FacebookUrl)
                .IsUnicode(false);

            user
                .HasOne(u => u.Country)
                .WithMany(c => c.Users)
                .OnDelete(DeleteBehavior.Restrict);

            user
                .HasOne(u => u.City)
                .WithMany(c => c.Users)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
