using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServisProgrami.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServisProgrami.Data.Seeds
{
   public class VehicleSeed:IEntityTypeConfiguration<Vehicle>
    {
        private readonly int[] _ids;

        public VehicleSeed(int[]ids)
        {
            _ids = ids;

        }
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                 new Vehicle { id = 1, Plaka = "55BY231", MotorNo = "XAFJAH49", SaseNo = "VCJ90000FGT6", Marka = "FIAT", Model = "PUNTO EVO 1.4", 
                     ModelYili = "2011", Renk = "SIYAH", Kilometre = "133000", KullanimTuru = "HUSUSI", CustomerId = _ids[0] }

                );
        }

        
    }
}
