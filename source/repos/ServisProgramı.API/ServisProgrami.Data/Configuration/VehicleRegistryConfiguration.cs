using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServisProgrami.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServisProgrami.Data.Configuration
{
    public class VehicleRegistryConfiguration : IEntityTypeConfiguration<VehicleRegistry>
    {
        public void Configure(EntityTypeBuilder<VehicleRegistry> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.Sikayetler).IsRequired().HasMaxLength(600);
            builder.Property(x => x.Durum);
        }
    }
}
