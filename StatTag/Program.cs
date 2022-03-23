using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatTag
{
    class Animal
    {
        static public int AnimalCounter = 0;

        public Animal()
        {
            ++Animal.AnimalCounter;
        }
        ~Animal()
        {
            --Animal.AnimalCounter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(Animal.AnimalCounter);
            Console.ReadKey();
        }
    }
}
