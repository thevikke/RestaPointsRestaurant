using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaPointsRestaurant.Models
{
    public class Kilpailut
    {
        public string Kuvat { get; set; }
        public string Nimi { get; set; }
        public string Selite { get; set; }
        public string Osallistujat { get; set; }
        public string AlkuAika { get; set; }
        public string LoppuAika { get; set; }
        public string Tavoite { get; set; }
        public string Palkinto { get; set; }
        public string Linkit { get; set; }
    }
}
