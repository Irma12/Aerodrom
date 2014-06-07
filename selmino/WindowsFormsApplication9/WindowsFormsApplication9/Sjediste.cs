using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class Sjediste
    {
        private string pozicija;
        private bool status;
        private int brojSjedista;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Pozicija
        {
            get { return pozicija; }
            set { pozicija = value; }
        }


        public int Brojsjedista
        {
            get { return brojSjedista; }
            set { brojSjedista = value; }
        }

        public Sjediste() {}

        public Sjediste(string _pozicija, bool _status, int _brojSjedista)
        {
            Brojsjedista = _brojSjedista;
            Pozicija = _pozicija;
            Status = _status;
        }

       

      
    }
}
