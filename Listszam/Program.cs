using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 metódusok:
-setHatar:Consolrol egy természetes számként beolvasom az elemekszámát, le kell ellenőrizni, hogy tényleg szám-e.
-setTort: Ennek az a feladata, hogy beolvas egy törtszámot.(tizedespont, perjel, tizedesvessző). Ha "." --> alakítsuk vesszővé; ha perjel, akkor tizedesszámmá és adja hozzá a listához. Írja ki mindig a beolvasott elemek számát és mennyit lehet még beolvasni. Hogyha az olvasás elérte a max mennyiséget, jelezze ki a felhasználónak és ha többet akar beadni, akkor ne fogadja el. 
-getLista: kiírja a consolra a számokat vesszővel elválasztva.
-getAtlag: A beolvasott számok átlagát kiírja a consolra.
-getOsszeg: Beolvasott számok összegét kiírja a consolra.
 
 */

namespace Listszam
{
    class ListSzam
    {
        private List<double> lista;
        private int listhossz;
        public ListSzam()
        {
            lista = new List<double>();
        }
        public void setHatar()
        {
            bool tovabb = false;
            do
            {
                try
                {
                    tovabb = false;
                    Console.WriteLine("Adja meg a lista hosszát!");
                    listhossz = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    tovabb = true;
                }

            } while (tovabb);

        }
        public void setTort()
        {
            string beolvasS = "";
            double beolvas;
            bool tovabb = false;
            do
            {
                try
                {

                    tovabb = false;
                    Console.WriteLine("Adja meg a lista elemét!");
                    beolvasS = Console.ReadLine();
                    beolvas = Convert.ToDouble(beolvasS);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    beolvas = Convert.ToDouble(beolvasS.Replace('.', ','));

                    if (beolvasS.Contains("/"))
                    {
                        int perjel = beolvasS.IndexOf("/");
                        int szamlalo = Convert.ToInt32(beolvasS.Substring(0, perjel));
                        int nevezo = Convert.ToInt32(beolvasS.Substring(perjel, beolvasS.Length - perjel));

                        beolvas = szamlalo / nevezo;
                    }

                    tovabb = true;
                }
                lista.Add(beolvas);
            } while (listhossz > lista.Count());

        }

        public void getLista()
        {
            foreach (var item in lista)
            {
                Console.Write("{0}, ", item);
            }
        }

        public void getAtlag() {
            double atlag = 0;

            atlag = getOsszeg() / lista.Count();

            Console.WriteLine("Az átlag: {0}", atlag);
        }

        public double getOsszeg()
        {
            double osszeg = 0;

            foreach (var item in lista)
            {
                osszeg += item;
            }

            return osszeg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListSzam listSzam = new ListSzam();
            listSzam.setHatar();
            listSzam.setTort();
            listSzam.getLista();
            listSzam.getAtlag();

            Console.WriteLine("Az összeg: {0}", listSzam.getOsszeg());

            Console.ReadKey();
        }
    }
}
