using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class Osoba
    {
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

       
        private Odjeli odjel;
        public Odjeli Odjel {
            get { return odjel;  }
            set { Odjel = odjel;  }
        }

        private int id;
        public int Id {
            get { return Id; }
            set { Id = id; }
        }

        public Osoba(string i, string p,  Odjeli o, int id) {
            Ime = i;
            Prezime = p;
            odjel = o;
            Id = id;
        }

        public Osoba(string i, string p, int id)
        {
            Ime = i;
            Prezime = p;
            Id = id;
        }

        public Osoba() { }

    }
}
