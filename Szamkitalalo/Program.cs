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
                felsoHatar = 11,   // Véletlenszám felső határa + 1
                gondoltSzam,
                tippAlsoHatar,
                tippFelsoHatar,
                tipp,
                probal = 5; // A próbálkozások maximális száma

            Random rnd = new Random();

            // Játék ismétlése
            do
            {
                // Megkérdezem, hogy ki lesz a kitaláló
                Console.WriteLine("Leszel az, aki gondol egy számra? (i /n)");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    // Ha játékos a kitaláló
                    // A gép generálja a kitalálandó számot
                    gondoltSzam = rnd.Next(alsoHatar, felsoHatar);

                    // A játékos max probal értékig tippel
                    for (int i = 0; i <= probal; i++)
                    {
                        // Beolvasom a tippet
                        Console.WriteLine("\nTippeljen! ");
                        tipp = int.Parse(Console.ReadLine());
                        // Kiértékelem a tippet
                        if (gondoltSzam < tipp) // Ha nagyobb a tipp
                        {
                            Console.WriteLine("Kisebb számra gondoltam");
                        }else if(gondoltSzam > tipp)    // Ha kisebb a tipp
                        {
                            Console.WriteLine("Nagyobb számra gondoltam");
                        }
                        else      // Eltalálta
                        {
                            Console.WriteLine("Gratulálok, eltalálta");
                            break;
                        }
                    }
                }
                else    // Ha a gép a kitaláló
                {

                    // A gép max probal értékig tippel
                    for (int i = 0; i <= probal; i++)
                    {
                        // A gép tippjének meghatározása

                        Console.WriteLine("\nTippeljen! ");
                        tipp = int.Parse(Console.ReadLine());
                        // Kiértékelem a tippet
                        if (gondoltSzam < tipp) // Ha nagyobb a tipp
                        {
                            Console.WriteLine("Kisebb számra gondoltam");
                        }
                        else if (gondoltSzam > tipp)    // Ha kisebb a tipp
                        {
                            Console.WriteLine("Nagyobb számra gondoltam");
                        }
                        else      // Eltalálta
                        {
                            Console.WriteLine("Gratulálok, eltalálta");
                            break;
                        }
                    }

                    
                    // A játékos megadja a kiértékelést
                }

                Console.WriteLine("\nFolytatjuk a játékot? (i/n)");
            } while (Console.ReadKey().KeyChar == 'i');
            // Eof Játék ismétlése
            Console.ReadKey();

        }
    }
}
