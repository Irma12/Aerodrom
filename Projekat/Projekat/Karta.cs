using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekat
{
    public class Karta
    {
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

      
        private string brojKarte;
        public string BrojKarte
        {
            get { return brojKarte; }
            set { brojKarte = value; }
        }

        private Putnik putnik;

        public Putnik Putnikk
        {
            get { return putnik; }
            set { putnik = value; }
        }

        public Karta(string _brojKarte, Putnik _putnik, string _status)
        {
            BrojKarte = _brojKarte; Putnikk = _putnik; Status = _status;
        }

        public Karta() { }

   
   


   

    }
}
