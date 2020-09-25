using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> order)
        {
            order
                .Property(o => o.AdditionalInformation)
                .IsUnicode(true);

            order
                .Property(o => o.Address)
                .IsUnicode(true);

            order
                .Property(o => o.City)
                .IsUnicode(true);

            order
                .Property(o => o.FirstName)
                .IsUnicode(true);

            order
                .Property(o => o.LastName)
                .IsUnicode(true);
        }
    }
}
