using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentekenRegistratie.Objects
{
    public class Persoon
    {
        public int BSN { get; private set; }
        public string Voornaam { get; private set; }
        public string Achternaam { get; private set; }
        public string Tussenvoegsel { get; private set; }
        public string Woonplaats { get; private set; }
        public string Adres { get; private set; }
        public string Postcode { get; private set; }

        /// <summary>
        /// Persoon class instantie zonder voornaam
        /// </summary>
        /// <param name="bsn"></param>
        /// <param name="voornaam"></param>
        /// <param name="achternaam"></param>
        /// <param name="woonplaats"></param>
        /// <param name="adres"></param>
        /// <param name="postcode"></param>
        public Persoon(int bsn, string voornaam, string achternaam, string woonplaats, string adres, string postcode)
        {
            BSN = bsn;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Woonplaats = woonplaats;
            Adres = adres;
            Postcode = postcode;
        }

        /// <summary>
        /// Persoon class instantie met voornaam
        /// </summary>
        /// <param name="bsn"></param>
        /// <param name="voornaam"></param>
        /// <param name="achternaam"></param>
        /// <param name="tussenvoegsel"></param>
        /// <param name="woonplaats"></param>
        /// <param name="adres"></param>
        /// <param name="postcode"></param>
        public Persoon(int bsn, string voornaam, string achternaam, string tussenvoegsel, string woonplaats, string adres, string postcode)
        {
            BSN = bsn;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Tussenvoegsel = tussenvoegsel;
            Woonplaats = woonplaats;
            Adres = adres;
            Postcode = postcode;
        }

        /// <summary>
        /// Haalt de volledige naam op
        /// </summary>
        /// <returns></returns>
        public string VolledigeNaam()
        {
            if(Tussenvoegsel == null || Tussenvoegsel == "")
            {
                return string.Format("{0} {1}", Voornaam, Achternaam);
            }
            else
            {
                return string.Format("{0} {1} {2}", Voornaam, Tussenvoegsel, Achternaam);
            }

        }

        /// <summary>
        /// Haalt het volledige adres op
        /// </summary>
        /// <returns></returns>
        public string VolledigAdres()
        {
            return string.Format("{0} {1} {2}",Adres,Woonplaats,Postcode);
        }

    }
}
