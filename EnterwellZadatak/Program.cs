using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterwellZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            #region poslovneJedinice
            PoslovnaJedinica jedinica01 = new PoslovnaJedinica
            {
                Naziv = "Jedinica01"
            };
            PoslovnaJedinica jedinica02 = new PoslovnaJedinica
            {
                Naziv = "Jedinica02"
            };
            PoslovnaJedinica jedinica11 = new PoslovnaJedinica
            {
                Naziv = "Jedinica11",
                Roditelj = jedinica01
            };
            PoslovnaJedinica jedinica12 = new PoslovnaJedinica
            {
                Naziv = "Jedinica12",
                Roditelj = jedinica01
            };
            PoslovnaJedinica jedinica111 = new PoslovnaJedinica
            {
                Naziv = "Jedinica111",
                Roditelj = jedinica11
            };
            PoslovnaJedinica jedinica112 = new PoslovnaJedinica
            {
                Naziv = "Jedinica112",
                Roditelj = jedinica11
            };
            #endregion
            #region vjestine
            Vjestina vjestina1 = new Vjestina
            {
                Ime = "rad na racunalu"
            };
            Vjestina vjestina2 = new Vjestina
            {
                Ime = "elektronika"
            };
            Vjestina vjestina3 = new Vjestina
            {
                Ime = "upravljanje automobilom"
            };
            Vjestina vjestina4 = new Vjestina
            {
                Ime = "dijagnoza"
            };
            Vjestina vjestina5 = new Vjestina
            {
                Ime = "telefonske instalacije"
            };
            #endregion
            #region djelatnici
            Djelatnik direktor1 = new Direktor
            {
                Ime = "dsafadf",
                Prezime = "fdsfds",
                OIB = "00000000001",
                Jedinica = jedinica12,
                NazivSluzAuta = "Chevrolet Aveo"
            };
            Djelatnik direktor2 = new Direktor
            {
                Ime = "ssss",
                Prezime = "dddd",
                OIB = "00000000002",
                Jedinica = jedinica112,
                NazivSluzAuta = "Chevrolet Spark"
            };
            Djelatnik direktor3 = new Direktor
            {
                Ime = "ddddsa",
                Prezime = "vdssdvsv",
                OIB = "00000000003",
                Jedinica = jedinica111,
                NazivSluzAuta = "Chevrolet Bolt"
            };
            Djelatnik direktor4 = new Direktor
            {
                Ime = "ppppppp",
                Prezime = "eeeeee",
                OIB = "00000000004",
                Jedinica = jedinica11,
                NazivSluzAuta = "Opel Astra"
            };
            Djelatnik direktor5 = new Direktor
            {
                Ime = "qqqqqq",
                Prezime = "wwwwww",
                OIB = "00000000005",
                Jedinica = jedinica02,
                NazivSluzAuta = "Opel Antara"
            };
            Djelatnik direktor6 = new Direktor
            {
                Ime = "errrrr",
                Prezime = "tttttttt",
                OIB = "00000000006",
                Jedinica = jedinica01,
                NazivSluzAuta = "Opel Astra"
            };


            Djelatnik serviser1 = new Serviser
            {
                Ime = "yyyyyyyy",
                Prezime = "uuuu",
                OIB = "00000000007",
                Jedinica = jedinica111,
                Vjestine = new List<Vjestina>
                { vjestina1,vjestina3}
            };
            Djelatnik serviser2 = new Serviser
            {
                Ime = "iiiiii",
                Prezime = "oooo",
                OIB = "00000000008",
                Jedinica = jedinica11,
                Vjestine = new List<Vjestina>
                { vjestina2,vjestina4}
            };
            Djelatnik serviser3 = new Serviser
            {
                Ime = "pppppp",
                Prezime = "ggggg",
                OIB = "00000000009",
                Jedinica = jedinica02,
                Vjestine = new List<Vjestina>
                { vjestina1}
            };
            Djelatnik serviser4 = new Serviser
            {
                Ime = "hhhhhhh",
                Prezime = "jjjjjjj",
                OIB = "00000000010",
                Jedinica = jedinica01,
                Vjestine = new List<Vjestina>
                { vjestina1, vjestina2,vjestina3,vjestina4,vjestina5}
            };
            Djelatnik serviser5 = new Serviser
            {
                Ime = "bbbbbb",
                Prezime = "vvv",
                OIB = "00000000011",
                Jedinica = jedinica12,
                Vjestine = new List<Vjestina>
                { vjestina3,vjestina4,vjestina5}
            };
            Djelatnik serviser6 = new Serviser
            {
                Ime = "nnnnnn",
                Prezime = "mmmmmmmm",
                OIB = "00000000012",
                Jedinica = jedinica112,
                Vjestine = new List<Vjestina>
                { vjestina1, vjestina5}
            };
            #endregion
            Organizacija org = new Organizacija
            {
                Ime = "iServis d.o.o.",
                Adresa = "Anticova 5, 52100 Pula",
                PoslovneJedinice = new List<PoslovnaJedinica>
                {
                    jedinica01,jedinica02,jedinica11,jedinica111,jedinica112,jedinica12
                },
                Djelatnici = new List<Djelatnik>
                {
                    direktor1,direktor2,direktor3,direktor4,direktor5,direktor6,
                    serviser1,serviser2,serviser3,serviser4,serviser5,serviser6
                }
            };

            ispisPoslovnice(jedinica01,org);
            Console.ReadLine();
        }

        // ispisuje prvo podatke o poslovnici, pa o njenim radnicima i onda rekurzivno se poziva za poslovnice ispod nje
        private static void ispisPoslovnice(PoslovnaJedinica jedinica,Organizacija org)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Naziv poslovne jedinice: "+jedinica.Naziv);

            string roditelj = jedinica.Roditelj == null ? "" : jedinica.Roditelj.Naziv;

            Console.WriteLine("Naziv nadredjene jedinice: " + roditelj);
            Console.WriteLine("Ime | Prezime | OIB | Dodatne informacije");

            foreach(Djelatnik d in org.Djelatnici.Where(x => x.Jedinica == jedinica))
            {
                d.Ispis();
            }
            Console.WriteLine("-------------------------");
            
            foreach(PoslovnaJedinica pj in org.PoslovneJedinice.Where(x => x.Roditelj == jedinica))
            {
                ispisPoslovnice(pj, org);
            }
        }

    }
}
