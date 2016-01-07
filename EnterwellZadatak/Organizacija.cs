using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterwellZadatak
{
    public class Organizacija
    {
        private string ime;
        private List<PoslovnaJedinica> poslovneJedinice=new List<PoslovnaJedinica>();
        private List<Djelatnik> djelatnici = new List<Djelatnik>();
        private string adresa;

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

        public List<PoslovnaJedinica> PoslovneJedinice
        {
            get
            {
                return poslovneJedinice;
            }

            set
            {
                poslovneJedinice = value;
            }
        }

        public List<Djelatnik> Djelatnici
        {
            get
            {
                return djelatnici;
            }

            set
            {
                djelatnici = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }
    }
}