using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServisProgrami.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServisProgrami.Data.Configuration
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.Plaka).IsRequired();
            builder.Property(x => x.MotorNo);
            builder.Property(x => x.SaseNo).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Marka).IsRequired().HasMaxLength(70);
            builder.Property(x => x.Model).IsRequired().HasMaxLength(70);
            builder.Property(x => x.ModelYili).IsRequired();
            builder.Property(x => x.Renk);
            builder.Property(x => x.Kilometre);
            builder.Property(x => x.KullanimTuru);
            builder.Property(x => x.Kilometre);

        }
    }
}
