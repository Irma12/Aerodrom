using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class Napomena
    {
        public enum napomene { poletio, sletio, otkazan, kasni };
       public  Let l;

        public void unesiNapomenu(Let l, Napomena n){
        l.Napomene = n;
        }

        public void prikaziNapomenu(Let l) {
            Console.WriteLine("Napomena: ", l.Napomene);
        }

    }
}
