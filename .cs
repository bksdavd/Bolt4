using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt4
{
    class Tejtermek : Termek
    {
        int lfj; // lfj = le fog járni x napon belül

        public Tejtermek(string nev, string kod, int ar, bool laktoz, int lfj) : base(nev, kod, ar, laktoz)
        {
            this.Lfj = lfj;
        }

        public Tejtermek(string nev, string kod, int lfj) : base (nev, kod)
        {
            this.Lfj = lfj;
        }

        public int Lfj { get => lfj; set => lfj = value; }

        public override string ToString()
        {
            return nev + ";" + kod + ";" + ar + ";" + laktoz + ";" + lfj;
        }
    }
}
