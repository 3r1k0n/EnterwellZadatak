using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterwellZadatak
{
    public class PoslovnaJedinica : Ispisivanje
    {
        private string naziv;
        private PoslovnaJedinica roditelj;

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public PoslovnaJedinica Roditelj
        {
            get
            {
                return this.roditelj;
            }

            set
            {
                this.roditelj = value;
            }
        }

        public void Ispis()
        {
            Console.WriteLine("Naziv poslovne jedinice: " + Naziv);

            string roditeljString = Roditelj == null ? "" : Roditelj.Naziv;

            Console.WriteLine("Naziv nadredjene jedinice: " + roditeljString);
        }
    }
}