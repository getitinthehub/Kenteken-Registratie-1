using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentekenRegistratie.Objects
{
    public class Gebruiker
    {
        public int BSN { get; private set; }
        public string Gebruikersnaam { get; private set; }

        // 0 = politie
        // 1 = RDW
        public int SoortGebruiker { get; private set; }

        public Gebruiker(int bsn, string gebruikersnaam, int soortgebruiker)
        {
            BSN = bsn;
            Gebruikersnaam = gebruikersnaam;
            SoortGebruiker = soortgebruiker;
        }

    }
}
