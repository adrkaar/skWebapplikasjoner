using KundeApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KundeApp.Controllers
{
    [Route("[controller]/[action]")]
    public class KundeController: ControllerBase
    {
        public List<Kunde> HentAlle()
        {
            var kundene = new List<Kunde>();

            var kunde1 = new Kunde();

            kunde1.navn = "Adriano navn";
            kunde1.adresse = "Gatenesen 21";

            var kunde2 = new Kunde
            {
                navn = "Navn navnesen",
                adresse = "Adreseesne 292"
            };

            kundene.Add(kunde1);
            kundene.Add(kunde2);

            return kundene;
        }
    }
}
