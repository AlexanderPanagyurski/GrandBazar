namespace GrandBazar.Data.Configurations
{
    using GrandBazar.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> appUser)
        {
            appUser
               .Property(u => u.FirstName)
               .IsUnicode(true);
            appUser
                .Property(u => u.LastName)
                .IsUnicode(true);
            appUser
                .Property(u => u.AboutMe)
                .IsUnicode(true);

            appUser
                .HasMany(e => e.Claims)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            appUser
                .HasMany(e => e.Logins)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            appUser
                .HasMany(e => e.Roles)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            appUser
                .HasOne(u => u.Country)
                .WithMany(c => c.Users)
                .OnDelete(DeleteBehavior.Restrict);

            appUser
                .HasOne(u => u.City)
                .WithMany(c => c.Users)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
