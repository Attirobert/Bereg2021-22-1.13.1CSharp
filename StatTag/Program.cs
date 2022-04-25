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

        // Destruktor nem hívható, ezért a számlálót csökkentjük, amikor törlünk egy új objektumot
        public void RemAnimal()
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
            int novel = 0,
                csokkent = 0;

            Console.WriteLine("Adjon meg egy természetes számot!");
            int szam = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < szam; i++)
            {
                if (rnd.Next(1, 100) % 2 == 0)
                {
                    lst.Add(new Animal());
                    novel++;
                }
                else if (lst.Count > 0)
                {
                    lst[0].RemAnimal(); 
                    lst.Remove(lst[0]);
                    csokkent++;
                }
            }

            Console.WriteLine("Növelte a listát: {0} db", novel);
            Console.WriteLine("Csökkentette a listát: {0} db", csokkent);
            Console.WriteLine("Lista elemeinek száma: {0}", lst.Count);
            Console.WriteLine("Objektumok száma: {0}", Animal.AnimalCounter);
            Console.ReadKey();
        }
    }
}
