using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterwellZadatak
{
    public class Serviser : Djelatnik
    {
        private List<Vjestina> vjestine = new List<Vjestina>();

        public List<Vjestina> Vjestine
        {
            get
            {
                return this.vjestine;
            }

            set
            {
                this.vjestine = value;
            }
        }

        public override void Ispis()
        {
            Console.WriteLine("{0} | {1} | {2} | {3}",Ime,Prezime,OIB,
                "Vjestine: "+String.Join(", ",Vjestine.Select(x=>x.Ime)));
        }
    }
}