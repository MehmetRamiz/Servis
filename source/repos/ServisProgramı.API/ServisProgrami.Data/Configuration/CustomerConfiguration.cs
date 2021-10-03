using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServisProgrami.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServisProgrami.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.HesapAdi).IsRequired().HasMaxLength(250);
            builder.Property(x => x.vergiNo);

            builder.Property(x => x.Telefon);
            builder.Property(x => x.Adres).HasMaxLength(300);
            builder.Property(x => x.RelaseDate);
        }
    }
}
