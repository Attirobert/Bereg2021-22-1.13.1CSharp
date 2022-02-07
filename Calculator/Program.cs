using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int szam1;
            int szam2;
            char muvjel;
            float eredm = 0;
            string uzen = "A művelet eredménye: ";

            // Beolvasások
            //szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adjon meg egy számot");
            szam1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adjon meg műveleti jelet");
            muvjel = Convert.ToChar(Console.Read());
            Console.ReadLine(); // Billentyűzet puffer ürítése

            Console.WriteLine("Adjon meg egy másik számot");
            szam2 = Convert.ToInt32(Console.ReadLine());

            //szam2 = int.Parse(Console.ReadLine());

            switch (muvjel)
            {
                case '+':
                    eredm = szam1 + szam2;
                    break;

                case '-':
                    eredm = szam1 - szam2;
                    break;

                case '*':
                    eredm = szam1 * szam2;
                    break;

                case '/':
                    eredm = szam1 / szam2;
                    break;

                default:
                    uzen = "Hibás műveleti jel";
                    break;
            }

            Console.WriteLine(uzen + eredm);
            Console.ReadKey();
        }
    }
}
