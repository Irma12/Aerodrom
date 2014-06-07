using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class RedLetova
    {
        private List<Let> letovi;
        private int brojLetova;
        public int BrojLetova
        {
            get { return brojLetova; }
            set { brojLetova = value; }
        }

    public void prikaziLet(Let l) {
        Console.WriteLine("Let broj: %1, destinacija: %2, vrijeme polaska: %3, vrijeme dolaska: %4, gate: %5, kašnjenje: %6, napomena: %7",l.BrojLeta,
                           l.Destinacija, l.VrijemePolaska, l.VrijemeDolaska, l.Gate, l.Kasnjenje, l.Napomene); 
}

        public void izlistaj() {
            foreach (Let l in letovi)
            {
                Console.WriteLine("Let broj: %1, destinacija: %2, vrijeme polaska: %3, vrijeme dolaska: %4, gate: %5, kašnjenje: %6, napomena: %7", l.BrojLeta,
                                   l.Destinacija, l.VrijemePolaska, l.VrijemeDolaska, l.Gate, l.Kasnjenje, l.Napomene);
            }
        }

    }
    }

