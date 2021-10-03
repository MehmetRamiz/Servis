using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServisProgrami.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServisProgrami.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.ParcaKodu).IsRequired();
            builder.Property(x => x.ParcaAdi).IsRequired().HasMaxLength(200);

           builder.Property(x => x.Miktar);
            builder.Property(x => x.Tutar).IsRequired().HasColumnType("decimal(18,2)");
        }
    }
}
