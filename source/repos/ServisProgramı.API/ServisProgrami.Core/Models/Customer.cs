﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServisProgrami.Core.Models
{
    public class Customer
    {

        public Customer()
        {
            Vehicles = new Collection<Vehicle>();
        }
        public int id { get; set; }

        public string HesapAdi { get; set; }

        public string vergiNo { get; set; }

        public string Adres { get; set; }

        [DataType(DataType.Date)]
        public DateTime RelaseDate ;

        public  string Telefon { get; set; }

       

        public ICollection<Vehicle> Vehicles { get; set; }









    }
}
