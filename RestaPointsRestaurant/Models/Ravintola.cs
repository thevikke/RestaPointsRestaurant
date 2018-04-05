using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaPointsRestaurant.Models
{
    public class Ravintola
    {
        public string Nimi { get; set; }
        public string Osoite { get; set; }
        public string Postinumero { get; set; }
        public string Puhelinnumero { get; set; }
        public string Sahkoposti { get; set; }
        public List<string> Aukioloajat { get; set; }
    }
}
