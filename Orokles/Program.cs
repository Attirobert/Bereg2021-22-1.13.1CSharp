using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        // Átlagos osztály
        class Allat
        {
            // Properties
            public string Name { get; set; }
            public string Hang { get; set; }

            public Allat() {
                this.Name = "Anonim";
                this.Hang = "Ki vagyok én?";
            }

            public Allat(string name)
            {
                this.Name = name;
                this.Hang = "Ki vagyok én?";
            }

            public string hangotAd()
            {
                return Hang;
            }

            // Virtuális metódus
            public virtual void mozog()
            {
                Console.WriteLine("Ezt a lezárt metódus írta ki.");
            }

        }

        // Virtuális metódusok
        class Kutya : Allat
        {
            // Lezárt metódus
            public sealed override void mozog()
            {
                Console.WriteLine("Ezt a lezárt metódus írta ki.");
            }


        }

        // Átlagos metódus felülírása (shadow hatás)

        // Virtuális metódus felülírása

        // Metódus lezárása

        // Osztály lezárása


        static void Main(string[] args)
        {
        }
    }
}
