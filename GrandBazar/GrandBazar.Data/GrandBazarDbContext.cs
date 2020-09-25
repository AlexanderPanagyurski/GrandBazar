using GrandBazar.Common;
using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data
{
    public class GrandBazarDbContext : DbContext
    {
        public GrandBazarDbContext()
        {
        }
        public GrandBazarDbContext( DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConfiguration.DefConnectionStr);
            }
            base.OnConfiguring(optionsBuilder);
        }

        //TODO: DbSets
        public DbSet<ChatMessage> ChatMessages { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderProduct> OrderProducts { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductComment> ProductComments { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<ProductReview> ProductReviews { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<User> Users { get; set; }

        //TODO: OnModelCreating Method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
