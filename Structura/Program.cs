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
    
    struct Test1
    {
        public int x;
    }

    
    // Konstruktor
    //    - 
    struct Test2
    {
        //public int x = 10; // nem kaphat kezdeti értéket
        public int x; // nem kaphat kezdeti értéket
        public int y;

        //public Test2() { }  // Nem jó, kötelező a paraméter; elhagyjuk, de meghívható
        public Test2(int x, int y) // ez sem jó, x nem kap értéket
        {
            this.y = y;
            this.x = x;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // Létrehozás new nélkül
            Test t0;
            t0.x = 3;
            Console.WriteLine("t0.x = {0}", t0.x); // x == 3
            Console.ReadKey();

            // Létrehozás new-val
            Test1 t1 = new Test1();
            Console.WriteLine("t1.x = {0}", t1.x); // x == 0
            Console.ReadKey();

            // x nem kapott értéket
            Test2 t2;
            t2.x = 22;
            Console.WriteLine("t2.x = {0}", t2.x); 
            Console.ReadKey();

            // new-val hozom létre
            Test2 t5 = new Test2(300, 400);
            Console.WriteLine("t5.x = {0}", t5.x); 
            Console.ReadKey();



            // Érték típusú 
            Test t3, t4;
            t3.x = 10;
            t4 = t3;
            t3.x = 221;
            Console.WriteLine("t3.x = {0}; t4.x = {1}", t3.x, t4.x);
            Console.ReadKey();
        }
    }
}
