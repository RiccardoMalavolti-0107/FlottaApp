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
    }
}
