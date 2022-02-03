using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konstansok
            const string FEJLESZTO = "Kovács Attila";

            // Változók
            string uzenet = "Helló Világ!";
            int szam = 10;
            double szam2 = 10.3;
            bool gender = true;
            char karakter = 's';
            string szoveg = "szöveg";


            // Program törzse
            Console.WriteLine(uzenet);
            Console.WriteLine(szam);
            Console.WriteLine(szam2);
            Console.WriteLine(gender);
            Console.WriteLine(karakter);
            Console.WriteLine(szoveg);
            Console.ReadKey();
        }
    }
}
