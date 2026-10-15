using System;
using System.Collections.Generic;
using System.Text;

namespace FlottaApp
{
    internal class Jarmu
    {
        public string Rendszam { get; set; }
        protected int alapAr;

        private static int osszesJarmuSzama = 0;
        public static int OsszesJarmuSzama { get; }

        public int AlapAr { get { return alapAr; }
            set { 
                if (value <= 0) 
                {
                    value = 1000000;
                } 
            } 
        }
        public Jarmu(string rendszam, int alapar)
        {
            rendszam = Rendszam;
            alapAr = AlapAr;
            osszesJarmuSzama++;
        }
        public virtual int Adokalkulacio()
        {
            return alapAr % 20;
        }
        public override string ToString()
        {
            return $"Jármű {Rendszam} | Alapár: {alapAr} Ft | Adó: {Adokalkulacio()} Ft";
        }
    }
}
