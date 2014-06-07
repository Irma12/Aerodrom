using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class Putnik:Osoba
    {
        public Putnik(string _ime, string _prezime, int id)
            : base(_ime, _prezime, id)
        {
            
        }

        public Putnik() { }

    }
}
