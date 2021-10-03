using System;
using System.Collections.Generic;
using System.Text;

namespace ServisProgrami.Core.Models
{
    public class Product
    {
        public int id { get; set; }

       public string ParcaKodu { get; set; }

        public string ParcaAdi { get; set; }

        public int Birim { get; set; }

        public int Miktar { get; set; }

        public decimal Tutar { get; set; }


    }
}
