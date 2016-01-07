using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterwellZadatak
{
    public class PoslovnaJedinica
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

    }
}