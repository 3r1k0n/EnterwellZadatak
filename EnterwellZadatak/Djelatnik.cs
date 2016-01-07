using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterwellZadatak
{
    public abstract class Djelatnik
    {
        private string ime;
        private string prezime;
        private string oib;
        private PoslovnaJedinica jedinica;

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string OIB
        {
            get
            {
                return oib;
            }

            set
            {
                oib = value;
            }
        }

        public PoslovnaJedinica Jedinica
        {
            get
            {
                return jedinica;
            }

            set
            {
                jedinica = value;
            }
        }
        public abstract void Ispis();
     
    }
}