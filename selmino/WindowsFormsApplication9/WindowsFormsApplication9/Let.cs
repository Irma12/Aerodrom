using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class Let
    {
       private DateTime vrijemePolaska;
       private DateTime vrijemeDolaska;
       private string destinacija;
       private string brojLeta;
       private string gate;
       private int kasnjenje;
       private Napomena napomene;
       public TipAviona avion = new TipAviona();
       public List<bool> slobodno;

       public Let(DateTime vp, DateTime vd, string d, string bl, string g, TipAviona a)
       {
           vrijemePolaska = vp;
           VrijemeDolaska = vd;
           Destinacija = d;
           BrojLeta = bl;
           Gate = g;
           avion = a;
           slobodno = new List<bool>(a.BrojSjedista);
           for (int i = 0; i < a.BrojSjedista; i++)
           {
               slobodno[i] = false;
           }
       }


       public DateTime VrijemePolaska {
           get { return vrijemePolaska; }
           set { vrijemePolaska = value; }
       
       }

       public DateTime VrijemeDolaska
       {
           get { return vrijemeDolaska; }
           set { vrijemeDolaska = value; }

       }

       public string Destinacija {
           get { return destinacija; }
           set { destinacija = value; }
       
       }

       public string BrojLeta {
           get { return brojLeta; }
           set { brojLeta = value; }
       }

       public string Gate {
           get { return gate; }
           set { gate = value; }
       }

       public Napomena Napomene {
           get { return napomene; }
           set { napomene = value; }
       }

       public int Kasnjenje {
           get { return kasnjenje; }
           set { kasnjenje = value; }
       }
                      

        

        public void unesiNapomenu(Napomena n) { 
          Napomene=n;
       }

        public void unesiKasnjenje (int minute) {
        Kasnjenje=minute;
     }

       

    }
}
