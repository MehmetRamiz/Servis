using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServisProgrami.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServisProgrami.Data.Configuration
{
    public class IscilikConfiguration : IEntityTypeConfiguration<Iscilik>
    {
        public void Configure(EntityTypeBuilder<Iscilik> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.OnarimNo);
            builder.Property(x => x.OnarimAdi).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Miktar);
            builder.Property(x => x.birim);
            builder.Property(x => x.Tutar).IsRequired().HasColumnType("decimal(18,2)");
            

        }
    }
}
