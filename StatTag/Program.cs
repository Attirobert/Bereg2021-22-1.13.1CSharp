using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatTag
{
    class Animal
    {
        // Az objektum példányok számát tartjuk nyílván
        static public int AnimalCounter = 0;

        // Konstruktor; a számlálót növeljük, amikor létre hozunk egy új objektumot
        public Animal()
        {
            ++Animal.AnimalCounter;
        }

        // Destruktor; a számlálót csökkentjük, amikor törlünk egy új objektumot
        ~Animal()
        {
            --Animal.AnimalCounter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Animal> lst = new List<Animal>();
            bool uj = true;

            int szam = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < szam; i++)
            {
                if (Convert.ToBoolean(rnd.Next(0, 1)))
                {
                    lst.Add(new Animal());
                }
                else if (lst.Count > 0)
                {
                    lst.Remove(lst[0]);
                }
            }

            Console.WriteLine("Várjunk egy kicsit, hogy a takarítás megtörténjen");
            Console.ReadKey();
            Console.WriteLine("Lista elemeinek száma: {0}", lst.Count);
            Console.WriteLine("Objektumok száma: {0}", Animal.AnimalCounter);
            Console.ReadKey();
        }
    }
}
