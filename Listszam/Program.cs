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

            bool tovabb = false;
            do
            {
                try
                {

                    tovabb = false;
                    Console.WriteLine("Adja meg a lista lista elemét!");
                    string beolvasS = Console.ReadLine();
                    double beolvas = Convert.ToDouble(beolvasS);
                    lista.Append(beolvas);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    tovabb = true;
                    throw;
                }

            } while (tovabb);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListSzam listSzam = new ListSzam();
            listSzam.setTort();
            Console.ReadKey();
        }
    }
}
