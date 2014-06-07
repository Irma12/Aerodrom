using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class Karta
    {
        private int brojKarte;
        public int BrojKarte
        {
            get { return brojKarte; }
            set { brojKarte = value; }
        }

        private TipAviona avion;
        public TipAviona Avion
        {
            get { return avion; }
            set { avion = value; }
        }

        private int brojacKarti;
        public int BrojacKarti
        {
            get { return brojacKarti; }
            set { brojacKarti = 0; }
        }

        private string brojLeta;
        public string BrojLeta
        {
            get { return brojLeta; }
            set { brojLeta = value; }
        }

        private string destinacija;
        public string Destinacija
        {
            get { return destinacija; }
            set { destinacija = value; }
        }

        private string brojSjedista;
        public string BrojSjedista
        {
            get { return brojSjedista; }
            set { brojSjedista = value; }
        }

        private string gate;
        public string Gate
        {
            get { return gate; }
            set { gate = value; }
        }

        private Putnik putnik;
        public Putnik Putnik
        {
            get { return putnik; }
            set { putnik = value; }
        }

        public Karta(int _brojKarte, string _brojSjedista, string _gate, Putnik _putnik)
        {
            BrojKarte = _brojKarte; BrojSjedista = _brojSjedista; Gate = _gate; Putnik = _putnik;
            brojacKarti++;
        }

        public Karta() { }

        public void IsprintajKartu() {
            Console.WriteLine("Broj karte: %1\n, Putnik: %2\n, BrojLeta: %3\n, Destinacija: %4\n, Broj sjedišta: %5\n, Gate: %6\n ", brojKarte, Putnik, brojLeta, destinacija, brojSjedista, gate);
        }

        public bool imaLiSlobodno() {
            if (brojacKarti == avion.BrojSjedista)
                return true;
            else return false;
        }


    }
}
