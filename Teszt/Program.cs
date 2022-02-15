using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
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
            Console.ReadKey();
        }
    }
}
