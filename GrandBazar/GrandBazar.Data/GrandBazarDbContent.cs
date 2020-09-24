using GrandBazar.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data
{
    public class GrandBazarDbContent : DbContext
    {
        public GrandBazarDbContent()
        {
        }
        public GrandBazarDbContent( DbContextOptions options)
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
        //TODO: OnModelCreating Method
    }
}
