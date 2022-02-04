using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtable
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;

            // Ha kapok számot a parancssorból
            if (args.Length > 0)
            {
                // akkor átalakítom
                szam = int.Parse(args[0]);
            }
            else
            {
                // ha nem, akkor generálok
                Random rnd = new Random();
                szam = rnd.Next(1, 50);
            }

            // Kiíratom az eredményt
            Console.WriteLine(szam * 2);
            Console.ReadKey();
        }
    }
}
