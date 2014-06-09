using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekat
{
    public class Let
    {
        private DateTime vrijemePolaska;
        private DateTime vrijemeDolaska;
        private string destinacija;
        private string brojLeta;
        private string gate;
        private string kasnjenje;
        private TipAviona tipAv;
        public List<Karta> karte;
        public List<bool> sjedista;
 
        // private Napomena napomena;

        public TipAviona TipAv
        {
            get { return tipAv; }
            set { tipAv = value; }
        }

        public DateTime VrijemePolaska
        {
            get { return vrijemePolaska; }
            set { vrijemePolaska = value; }
        }

        public DateTime VrijemeDolaska
        {
            get { return vrijemeDolaska; }
            set { vrijemeDolaska = value; }
        }

        public string Destinacija
        {
            get { return destinacija; }
            set { destinacija = value; }
        }
        public string BrojLeta
        {
            get { return brojLeta; }
            set { brojLeta = value; }
        }

        public string Gate
        {
            get { return gate; }
            set { gate = value; }
        }
        public string Kasnjenje
        {
            get { return kasnjenje; }
            set { kasnjenje = value; }
        }

        private decimal cijena;

        public decimal Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }
       


        public Let(string p1, string p2, DateTime dateTime1, DateTime dateTime2, string p3, TipAviona p4, decimal _cijena)
        {
            BrojLeta = p1;
            Destinacija = p2;
            VrijemePolaska = dateTime1;
            VrijemeDolaska = dateTime2;
            Gate = p3;
            TipAv = p4;
            karte = new List<Karta>();
            Cijena = _cijena;
            sjedista = new List<bool>();

           
        }

        public Let() { }

        public override string ToString()
        {
            return BrojLeta + ", " + Destinacija + ", " + VrijemePolaska.ToString();
        }


    }
}
