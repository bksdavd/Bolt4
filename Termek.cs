using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt4
{
    class Termek
    {
        protected string nev, kod;
        protected int ar;
        protected bool laktoz;

        public Termek(string nev, string kod)
        {
            this.nev = nev;
            this.kod = kod;
        }

        public Termek(string nev, string kod, int ar, bool laktoz)
        {
            this.Nev = nev;
            this.Kod = kod;
            this.Ar = ar;
            this.Laktoz = laktoz;
        }

        public Termek() { }

        public string Nev { get => nev; set => nev = value; }
        public string Kod { get => kod; set => kod = value; }
        public int Ar { get => ar; set => ar = value; }
        public bool Laktoz { get => laktoz; set => laktoz = value; }

        public override string ToString()
        {
            return nev + ";" + kod + ";" + ar + ";" + laktoz;
        }
    }
}
