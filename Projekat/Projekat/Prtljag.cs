using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekat
{
    public class Prtljag
    {
        private string kod;

        public string Kod
        {
            get { return kod; }
            set { kod = value; }
        }
        private string napomenaP;

        public string NapomenaP
        {
            get { return napomenaP; }
            set { napomenaP = value; }
        }

        public Prtljag(string k, string n)
        {
            Kod = k;
            NapomenaP = n;
        }
        public Prtljag() { }

        public override string ToString()
        {
            return Kod+"-napomena:"+NapomenaP;
        }
    }

        
    
}
