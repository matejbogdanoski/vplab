using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPLabTimer
{
    public class Igrach
    {
        public string Ime { get; set; }
        public int Poeni { get; set; }

        public Igrach(string ime, int poeni)
        {
            Ime = ime;
            Poeni = poeni;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} poeni",Ime,Poeni);
        }
    }
}
