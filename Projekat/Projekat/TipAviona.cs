using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekat
{
    public class TipAviona
    {
        private string imeTipa;

        public string ImeTipa
        {
            get { return imeTipa; }
            set { imeTipa = value; }
        }
        private int brojSjedista;

        public int BrojSjedista
        {
            get { return brojSjedista; }
            set { brojSjedista = value; }
        }

        public TipAviona(string ime, int sjed)
        {            
            ImeTipa = ime;
            BrojSjedista = sjed;
        }

        public TipAviona() { }

        public override string ToString()
        {
            return ImeTipa+"-"+BrojSjedista.ToString();
        }

    }
}
