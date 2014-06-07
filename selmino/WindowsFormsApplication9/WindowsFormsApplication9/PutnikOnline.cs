using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class PutnikOnline:Putnik
    {
        private string kod;
        public string Kod
        {
            get { return kod; }
            set { kod = value; }
        }

        public PutnikOnline(string _ime, string _prezime, String _kod, int id)
            : base(_ime, _prezime, id)
        {
            Kod = _kod;
        }

        public PutnikOnline() { }
    }
}
