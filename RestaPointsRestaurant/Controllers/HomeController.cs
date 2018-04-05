using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaPointsRestaurant.Models;

namespace RestaPointsRestaurant.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> aukioloajat = new List<string>{ "ma 08:00 - 16-00", "ti 08:00 - 16-00", "ke-to 10:00 - 18:00", "pe-su 08:00- 20:00" };

            Ravintola dragonsheng = new Ravintola {
                Nimi = "Dragon Sheng",
                Osoite = "Suokatu 33",
                Postinumero = "70110 Kuopio ",
                Puhelinnumero = " +358 17 2626718",
                Sahkoposti = "DragonSeng@gmail.fi",
                Aukioloajat = aukioloajat
            };
            
            return View(dragonsheng);
        }

        public IActionResult EditProfiili()
        {
            List<string> aukioloajat = new List<string> { "ma 08:00 - 16-00", "ti 08:00 - 16-00", "ke-to 10:00 - 18:00", "pe-su 08:00- 20:00" };

            Ravintola dragonsheng = new Ravintola
            {
                Nimi = "Dragon Sheng",
                Osoite = "Suokatu 33",
                Postinumero = "70110 Kuopio ",
                Puhelinnumero = " +358 17 2626718",
                Sahkoposti = "DragonSheng@gmail.fi",
                Aukioloajat = aukioloajat
            };
            return View(dragonsheng);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
