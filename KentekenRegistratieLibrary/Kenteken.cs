using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentekenRegistratie.Objects
{
    public class Kenteken
    {
        public int BSN { get; private set; }
        public string KentekenID { get; private set; }
        public string Merk { get; private set; }
        public bool IsVerzekerd { get; private set; } // true als verzekerd is
        public bool IsApkGekeurd { get; private set; } // true als gekeurd is
        public bool IsGestolen { get; private set; } // true als gestolen is

        public Kenteken(int bsn, string kentekenID, string merk, bool isVerzekerd, bool isAPKGekeurd, bool isGestolen)
        {
            BSN = bsn;
            KentekenID = kentekenID;
            Merk = merk;
            IsVerzekerd = isVerzekerd;
            IsApkGekeurd = isAPKGekeurd;
            IsGestolen = isGestolen;
        }

    }
}
