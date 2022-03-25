using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    class Kivetel
    {
        public Kivetel() { }

        // Nincs kivétel kezelés
        public void KivKezNincs()
        {
            Console.WriteLine("Nincs kivételkezelés\nAdjon meg egy karaktert!");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A beírt szám: {0}", szam);
            Console.ReadKey();
        }

        // Általános kivételkezelés
        public void KivKezAlt()
        {
            Console.WriteLine("\nHiba objektum nélküli kivételkezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch
            {
                throw;
            }
            Console.ReadKey();
        }

        // Őshiba objektummal
        public void KivKezOs()
        {
            Console.WriteLine("\nŐs Hiba objektummal kivételkezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }

        // Hiba objektummal
        public void KivKezObj()
        {
            Console.WriteLine("\nSaját Hiba objektummal kivételkezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kivetel kivetel = new Kivetel();
/*            kivetel.KivKezNincs();
            kivetel.KivKezAlt();
            kivetel.KivKezOs();*/
            kivetel.KivKezObj();

        }
    }
}
