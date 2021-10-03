using System;
using System.Collections.Generic;
using System.Text;

namespace ServisProgrami.Core.Models
{
   public  class Vehicle
    {

        public int id { get; set; }

        public string Plaka { get; set; }

        public string MotorNo { get; set; }

        public string SaseNo { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public string  ModelYili { get; set; }

        public string Renk { get; set; }

        public string KullanimTuru { get; set; }

        public string Kilometre { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Musteri { get; set; }

    }
}
