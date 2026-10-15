using System;
using System.Collections.Generic;
using System.Text;

namespace FlottaApp
{
    internal class teherauto : Jarmu
    {
        double TeherBiras { get; set; }

        public teherauto(double teherbiras,string rendszam, int alapAr) : base(rendszam,alapAr)
        {
            teherbiras = TeherBiras;
        }
        public override int Adokalkulacio()
        {
            return Convert.ToInt16( alapAr % 20 + (TeherBiras * 10000));
        }
        public override string ToString()
        {
            return $"Jármű {Rendszam} | Alapár: {AlapAr} Ft | Adó: {Adokalkulacio()} Ft";
        }
    }
}
