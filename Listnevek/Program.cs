using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Készitsünk oszályt nevek tárolására
 metódusok:
setHossz:bekérjük hogy hány nevet akarunk eltárolni
setNevek:Bekérünk annyi nevet amennyit a setHosszban beállított a felhasználó és ezeket hozzáadjuk a listához
getNevek:kiiratjuk vesszővel elválasztva a letárolt neveket
getVan:Bekérünk egy nevet és kiirjuk hogy szerepel -e a listában
setTorol:kitörli a listában lévő elemeket*/
namespace Listnevek
{
    class Nevek
    {
        private int nevek;
        private List<string> lista;
        private string nev;
        public Nevek()
        {
            lista = new List<string>();
        }
        public void setHossz()
        {
            Console.WriteLine("Hány nevet szeretnél eltárolni?");
            nevek = Convert.ToInt32(Console.ReadLine());
            
        }
        public void setNevek()
        {
            for (int i = 0; i < nevek; i++)
            {
                Console.WriteLine("adjon meg egy nevet");
                nev = Console.ReadLine();
                lista.Add(nev);
            }
          
           
        }
        public void getNevek()
        {
            Console.WriteLine("\nA tárolt nevek: ");
            foreach (var item in lista)
            {
                Console.WriteLine( item +",");
            }
            
        }
        public void getVan()
        {
            bool páros = false;

            Console.WriteLine("Adjon meg egy nevet");
            string új;
            új = Console.ReadLine();
            foreach (var item in lista)
            {
                if (item == új)
                {
                    Console.WriteLine("Van ilyen név!");
                    páros = true;
                    break;
                }
            }
            if (!páros)
            {
                Console.WriteLine("Nincs ilyen név");
            }

        }
        public void setTorol()
        {
            lista = new List<string>();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Nevek neve = new Nevek();
            neve.setHossz();
            neve.setNevek();
            neve.getNevek();
            neve.getVan();
            neve.setTorol();
            Console.ReadKey();

        }
    }
}
