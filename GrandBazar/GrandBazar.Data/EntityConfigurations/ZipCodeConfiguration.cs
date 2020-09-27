using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
    public class ZipCodeConfiguration : IEntityTypeConfiguration<ZipCode>
    {
        public void Configure(EntityTypeBuilder<ZipCode> builder)
        {
            builder
                .Property(x => x.City)
                .IsUnicode(true);

            builder
                .Property(x => x.Code)
                .IsUnicode(false);
        }
    }
}
