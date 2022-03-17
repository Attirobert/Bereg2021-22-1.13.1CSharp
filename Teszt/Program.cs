using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static ulong rekurzivFakt(ulong p)
        {
            if (p <= 1) return 1;
            return rekurzivFakt(p - 1) * p;
        }

        static void compSzoveg()
        {
            string a = " egyik";
            string b = "egyik ";
            int x = String.Compare(a, b);
            if (x == 0)
            {
                Console.WriteLine("A két string egyenlő");
            }
            else if (x < 0)
            {
                Console.WriteLine("Az 'a' a kisebb");
            }
            else
            {
                Console.WriteLine("A 'b' a kisebb");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("22 faktoriálisa: {0}",rekurzivFakt(22));
            Console.ReadKey();
        }
    }
}
