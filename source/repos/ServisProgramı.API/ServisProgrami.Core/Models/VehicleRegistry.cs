using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServisProgrami.Core.Models
{
    public class VehicleRegistry
    {
        public int id { get; set; }

        public string Sikayetler { get; set; }

        public string Durum { get; set; }

        [DataType(DataType.Date)]
        public DateTime RelaseDate;


    }
}
