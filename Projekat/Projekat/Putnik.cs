using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekat
{
    public class Putnik
    {
        private string licna;

        public string Licna
        {
            get { return licna; }
            set { licna = value; }
        }
        private string pasos;

        public string Pasos
        {
            get { return pasos; }
            set { pasos = value; }
        }

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

   

        public Putnik(string _ime, string _prezime, string _licna, string _pasos)
        {
            Ime = _ime; Prezime = _prezime; Licna = _licna; Pasos = _pasos;
        }

        public Putnik() { }
    }

    public class PutnikOnline : Putnik
    {
        private string kod;
        public string Kod
        {
            get { return kod; }
            set { kod = value; }
        }

        public PutnikOnline(string _ime, string _prezime, string _licna, string _pasos, string _kod)
            : base(_ime, _prezime, _licna, _pasos)
        {
            Kod = _kod;
        }
        public PutnikOnline() { }
    }

}
