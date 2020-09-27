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
        public DbSet<ChatMessage> ChatMessages { get; set; } // Checked 1

        public DbSet<City> Cities { get; set; } // Checked 2 

        public DbSet<Country> Countries { get; set; } // Checked 3 

        public DbSet<Order> Orders { get; set; } // Checked 4 

        public DbSet<OrderProduct> OrderProducts { get; set; } // Checked 5 

        public DbSet<Product> Products { get; set; } // Checked 6

        public DbSet<ProductCategory> ProductCategories { get; set; } // Checked 7

        public DbSet<ProductComment> ProductComments { get; set; } // Checked 8

        public DbSet<ProductImage> ProductImages { get; set; } // Checked 9 

        public DbSet<ProductReview> ProductReviews { get; set; } // Checked 10

        public DbSet<ShoppingCart> ShoppingCarts { get; set; } // Checked 11

        public DbSet<User> Users { get; set; } // Checked 12

        public DbSet<ZipCode> ZipCodes { get; set; } // Checked 13

        //TODO: OnModelCreating Method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
