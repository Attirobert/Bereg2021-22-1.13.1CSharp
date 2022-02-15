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

            char valaszom;  // A gép tippjére adott válaszom: k = kisebbre gondoltam, n = nagyobbra gondoltam, t = eltalálta

            bool eltalalta = false; // Gép eltalálta-e a tippet

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
                    // Megadom a kezdeti értéket
                    eltalalta = false;

                    // Tippelési határok beállítása
                    tippAlsoHatar = alsoHatar;
                    tippFelsoHatar = felsoHatar;

                    // A gép max probal értékig tippel
                    for (int i = 0; i <= probal; i++)
                    {
                        // A gép tippjének meghatározása
                        Console.WriteLine("\nGondolj egy számra! ");
                        tipp = (tippFelsoHatar - tippAlsoHatar) / 2;
                        Console.WriteLine("Az én tippem: {0}", tipp);

                        // Kiértékelem a tippet, megadom a választ
                        valaszom = Console.ReadKey().KeyChar;
                        if (valaszom == 'n')
                        {
                            Console.WriteLine("Nagyobbra gondoltam!");
                            tippAlsoHatar = tipp;
                        }
                        else if (valaszom == 'k')
                        {
                            Console.WriteLine("Kisebbre gondoltam!");
                            tippFelsoHatar = tipp;
                        }
                        else
                        {
                            eltalalta = true;
                            Console.WriteLine("Gratulálok, eltalálta!");
                            break;
                        }
                    }

                    // Ha nem találta el, akkor ezt írom ki
                    if (!eltalalta)
                    {
                        Console.WriteLine("Lejárt a tippek száma, de sajnos nem találta el!");
                    }
                    Console.ReadKey();
                }

                Console.WriteLine("\nFolytatjuk a játékot? (i/n)");
            } while (Console.ReadKey().KeyChar == 'i');
            // Eof Játék ismétlése
            Console.ReadKey();

        }
    }
}
