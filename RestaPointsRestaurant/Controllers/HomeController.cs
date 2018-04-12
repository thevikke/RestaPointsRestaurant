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

        public IActionResult Kilpailut()
        {
            List<Kilpailut> kilpailut = new List<Kilpailut>();
            Kilpailut kilpailu1 = new Kilpailut
            {
                Nimi = "Syö kung pao chicken",
                Selite = "Kun syöt Kun pao Chicken annoksen saat lisäpisteistä!",
                Osallistujat = "20 osallistunut",
                AlkuAika = "02.02.2018",
                LoppuAika = "30.04.2018",
                Tavoite = "50 osallistujaa",
                Palkinto = "100 pistettä",
                Linkit = "www.dragonsheng.com"
            };
            Kilpailut kilpailu2 = new Kilpailut
            {
                Nimi = "Kaverin kanssa enemmän",
                Selite = "Kerää jengisi kasaan, väh 4 hengen porukka saa palkinnon!",
                Osallistujat = "13 osallistunut",
                AlkuAika = "01.03.2018",
                LoppuAika = "15.04.2018",
                Tavoite = "45 osallistujaa",
                Palkinto = "150 pistettä",
                Linkit = "www.dragonsheng.com"
            };
            Kilpailut kilpailu3 = new Kilpailut
            {
                Nimi = "Nuudeli perjantai",
                Selite = "Syö nuudeleita perjantaina, voitat pisteitä!",
                Osallistujat = "70 osallistunut",
                AlkuAika = "03.03.2018",
                LoppuAika = "12.05.2018",
                Tavoite = "80 osallistujaa",
                Palkinto = "75 pistettä",
                Linkit = "www.dragonsheng.com"
            };
            kilpailut.Add(kilpailu1);
            kilpailut.Add(kilpailu2);
            kilpailut.Add(kilpailu3);
            return View(kilpailut);
        }

        public IActionResult Mainokset()
        {
            List<Mainokset> mainokset = new List<Mainokset>();
            Mainokset mainos1 = new Mainokset
            {
                Nimi = "Kuopion parasta kiinalaista!",
                Selite = "Yksi suomen parhaista ravintoloista, meillä on ravintolat Mikkelissä, Varkaudessa, Kuopiossa ja Iisalmessa",
                AlkuAika = "12.04.2018",
                LoppuAika = "15.05.2018"
            };
            Mainokset mainos2 = new Mainokset
            {
                Nimi = "Parhaat nuudelit meiltä!",
                Selite = "Kokkimme on osaa tehdä aitoja kiinalaisia nuudeleita, tule maistamaan",
                AlkuAika = "12.04.2018",
                LoppuAika = "15.05.2018"
            };
            mainokset.Add(mainos1);
            mainokset.Add(mainos2);
            return View(mainokset);
        }

        public IActionResult Ilmoitukset()
        {
            List<Ilmoitukset> ilmoitukset = new List<Ilmoitukset>();
            Ilmoitukset ilmoitus1 = new Ilmoitukset
            {
                Nimi = "Nuudelit juuri nyt!",
                Selite = "Tule hakemaan nuudelit saat 30% alennuksen",
                AlkuAika = "12.04.2018, klo 19:00",
                LoppuAika = "12.04.2018, klo 21:00"
            };
            Ilmoitukset ilmoitus2 = new Ilmoitukset
            {
                Nimi = "Kung pao chicken ilta- alennus!",
                Selite = "Kanaa iltanälkäisille, 50% alennuksen",
                AlkuAika = "12.04.2018, klo 18:00",
                LoppuAika = "12.04.2018, klo 22:00"
            };
            Ilmoitukset ilmoitus3 = new Ilmoitukset
            {
                Nimi = "Opiskelijoille tänään alennus!",
                Selite = "Opiskelijakorttia näyttämällä 10% alennus",
                AlkuAika = "13.04.2018, klo 08:00",
                LoppuAika = "14.04.2018, klo 21:00"
            };
            ilmoitukset.Add(ilmoitus1);
            ilmoitukset.Add(ilmoitus2);
            ilmoitukset.Add(ilmoitus3);
            return View(ilmoitukset);
        }

        public IActionResult MuokkaaKilpailut()
        {
            Kilpailut kilpailu1 = new Kilpailut
            {
                Nimi = "Syö kung pao chicken",
                Selite = "Kun syöt Kun pao Chicken annoksen saat lisäpisteistä!",
                Osallistujat = "20 osallistunut",
                AlkuAika = "02.02.2018",
                LoppuAika = "30.04.2018",
                Tavoite = "50 osallistujaa",
                Palkinto = "100 pistettä",
                Linkit = "www.dragonsheng.com"
            };

            return View(kilpailu1);
        }

        public IActionResult TiedotKilpailut()
        {
            Kilpailut kilpailu1 = new Kilpailut
            {
                Nimi = "Syö kung pao chicken",
                Selite = "Kun syöt Kun pao Chicken annoksen saat lisäpisteistä!",
                Osallistujat = "20 osallistunut",
                AlkuAika = "02.02.2018",
                LoppuAika = "30.04.2018",
                Tavoite = "50 osallistujaa",
                Palkinto = "100 pistettä",
                Linkit = "www.dragonsheng.com"
            };

            return View(kilpailu1);
        }
        public IActionResult PoistaKilpailut()
        {
            Kilpailut kilpailu1 = new Kilpailut
            {
                Nimi = "Syö kung pao chicken",
                Selite = "Kun syöt Kun pao Chicken annoksen saat lisäpisteistä!",
                Osallistujat = "20 osallistunut",
                AlkuAika = "02.02.2018",
                LoppuAika = "30.04.2018",
                Tavoite = "50 osallistujaa",
                Palkinto = "100 pistettä",
                Linkit = "www.dragonsheng.com"
            };

            return View(kilpailu1);
        }
        public IActionResult MuokkaaIlmoitukset()
        {
            Ilmoitukset ilmoitus1 = new Ilmoitukset
            {
                Nimi = "Nuudelit juuri nyt!",
                Selite = "Tule hakemaan nuudelit saat 30% alennuksen",
                AlkuAika = "12.04.2018, klo 19:00",
                LoppuAika = "12.04.2018, klo 21:00"
            };

            return View(ilmoitus1);
        }
        public IActionResult TiedotIlmoitukset()
        {
            Ilmoitukset ilmoitus1 = new Ilmoitukset
            {
                Nimi = "Nuudelit juuri nyt!",
                Selite = "Tule hakemaan nuudelit saat 30% alennuksen",
                AlkuAika = "12.04.2018, klo 19:00",
                LoppuAika = "12.04.2018, klo 21:00"
            };

            return View(ilmoitus1);
        }
        public IActionResult PoistaIlmoitukset()
        {
            Ilmoitukset ilmoitus1 = new Ilmoitukset
            {
                Nimi = "Nuudelit juuri nyt!",
                Selite = "Tule hakemaan nuudelit saat 30% alennuksen",
                AlkuAika = "12.04.2018, klo 19:00",
                LoppuAika = "12.04.2018, klo 21:00"
            };

            return View(ilmoitus1);
        }
        public IActionResult MuokkaaMainokset()
        {
            Mainokset mainos1 = new Mainokset
            {
                Nimi = "Kuopion parasta kiinalaista!",
                Selite = "Yksi suomen parhaista ravintoloista, meillä on ravintolat Mikkelissä, Varkaudessa, Kuopiossa ja Iisalmessa",
                AlkuAika = "12.04.2018",
                LoppuAika = "15.05.2018"
            };

            return View(mainos1);
        }
        public IActionResult TiedotMainokset()
        {
            Mainokset mainos1 = new Mainokset
            {
                Nimi = "Kuopion parasta kiinalaista!",
                Selite = "Yksi suomen parhaista ravintoloista, meillä on ravintolat Mikkelissä, Varkaudessa, Kuopiossa ja Iisalmessa",
                AlkuAika = "12.04.2018",
                LoppuAika = "15.05.2018"
            };

            return View(mainos1);
        }
        public IActionResult PoistaMainokset()
        {
            Mainokset mainos1 = new Mainokset
            {
                Nimi = "Kuopion parasta kiinalaista!",
                Selite = "Yksi suomen parhaista ravintoloista, meillä on ravintolat Mikkelissä, Varkaudessa, Kuopiossa ja Iisalmessa",
                AlkuAika = "12.04.2018",
                LoppuAika = "15.05.2018"
            };

            return View(mainos1);
        }
        public IActionResult UusiIlmoitus()
        {
            return View();
        }
        public IActionResult UusiKilpailu()
        {
            return View();
        }
        public IActionResult UusiMainos()
        {
            return View();
        }
        public IActionResult OtaYhteytta()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
