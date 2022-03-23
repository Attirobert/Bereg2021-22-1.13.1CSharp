using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiterjesztMetodus
{
    /* A StringHelper egy burkoló osztály a string kezeléshez.
     * Ezt bővítjük a Print metódussal
     * Mind a befogadó osztálynak, mind a kiterjesztett metódusnak "static public" jelölőkkel kell rendelkeznie.
     * Fontos még a metódus paraméterénél a "this" használata
     */
    static public class StringHelper
    {
        static public void Print(this string s)
        {
            Console.WriteLine(s);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "ezegystring";
            Console.WriteLine("s.Print()");
            s.Print();              // objektum metódusaként használva

            Console.WriteLine("\nStringHelper.Print(s)");
            StringHelper.Print(s);  // statikus osztály metódusként használva

            Console.ReadKey();
        }
    }
}
