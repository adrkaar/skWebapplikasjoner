using KundeApp.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KundeApp.Controllers
{
    [Route("[controller]/[action]")]
    public class KundeController: ControllerBase
    {
        private readonly KundeDB _kundeDB;

        public KundeController(KundeDB kundeDb)
        {
            _kundeDB = kundeDb;
        }

        public List<Kunde> HentAlle()
        {
            List<Kunde> alleKundene = _kundeDB.Kunder.ToList();
            return alleKundene;
        }
    }
}
