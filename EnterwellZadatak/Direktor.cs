using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterwellZadatak
{
    public class Direktor : Djelatnik
    {
        private string nazivSluzAuta;

        public string NazivSluzAuta
        {
            get
            {
                return nazivSluzAuta;
            }

            set
            {
                nazivSluzAuta = value;
            }
        }

        public override void Ispis()
        {
            Console.Write("Sluzbeno vozilo: " + NazivSluzAuta + "\n");
        }
    }
}