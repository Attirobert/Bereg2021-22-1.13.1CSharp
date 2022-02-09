using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamkitalalo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int alsoHatar = 1,  // Véletlenszám alsó határa
                felsoHatar = 101,   // Véletlenszám felső határa + 1
                gondoltSzam,
                tipp,
                probal = 5; // A próbálkozások maximális száma

            Random rnd = new Random();

            // Játék ismétlése
            do
            {
                // Megkérdezem, hogy ki lesz a kitaláló
                Console.WriteLine("Leszelaz, aki gondol egy számra? (i /n)");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    // Ha játékos a kitaláló
                    // A gép generálja a kitalálandó számot
                    gondoltSzam = rnd.Next(alsoHatar, felsoHatar);

                    // A játékos max probal értékig tippel
                    for (int i = 0; i <= probal; i++)
                    {
                        // Beolvasom a tippet
                        tipp = int.Parse(Console.ReadLine());
                        // Kiértékelem a tippet

                        // Ha nagyobb a tipp

                        // Ha kisebb a tipp

                        // Eltalálta
                    }
                }
                else
                {
                    // Ha a gép a kitaláló
                    // A gép max probal értékig tippel
                    // A gép tippjének meghatározása
                    // A játékos megadja a kiértékelést
                }

                Console.WriteLine("Folytatjuk a játékot? (i/n)");
            } while (Console.ReadKey().KeyChar == 'i');
            // Eof Játék ismétlése
            Console.ReadKey();

        }
    }
}
