using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class TipAviona
    {
        private string naziv;
        private Sjediste sjediste;
        private int brojSjedista;

        public int BrojSjedista { 
            get {return brojSjedista;} 
            set {brojSjedista=value;} }

        public Sjediste Sjediste
        {
            get { return sjediste; }
            set { sjediste = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public TipAviona() {}

        public TipAviona(string _naziv, Sjediste _sjediste) {
            Naziv = _naziv; Sjediste = _sjediste; 
        }
       
        
    }
}
