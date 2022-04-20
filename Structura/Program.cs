using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structura
{
    struct Test
    {
        public int x;
    }    
    
    struct Test2
    {
        public int x;
    }

    struct Test3
    {
        public int x = 10; // nem kaphat kezdeti értéket
        public int y;

        public Test3() { }  // Nem jó, kötelező a paraméter, elhagyjuk, de meghívható
        public Test3(int x, int y) // ez sem jó, x nem kap értéket
        {
            this.y = y; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // new nélkül
            Test s;
            s.x = 3;
            Console.WriteLine(s.x); // x == 0
            Console.ReadKey();

            Test t = new Test();
            Console.WriteLine(t.x); // x == 0
            Console.ReadKey();

            Test t2;
            Console.WriteLine(t2.x); // x nem kapott értéket
            Console.ReadKey();
        }
    }
}
