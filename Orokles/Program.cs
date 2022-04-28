using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        abstract class Ordog : IComparable
        {
            private int x;

            public Ordog() {
                this.x = 10;
            }

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            abstract public void ugrik();

        }
        // Átlagos osztály
        class Allat
        {
            // Properties
            public string Name { get; set; }
            public string Hang { get; set; }

            public Allat() {
                this.Name = "Anonim";
                this.Hang = "Én egy Allat vagyok";
            }

            public Allat(string name)
            {
                this.Name = name;
                this.Hang = "Én egy Allat vagyok";
            }

            public void hangotAd()
            {
                Console.WriteLine("Ezt a Allat.hangotAd() metódus írta ki.");
                Console.ReadKey();
            }

            // Virtuális metódus
            public virtual void mozog()
            {
                Console.WriteLine("Ezt a virtuális mozog() metódus írta ki.");
                Console.ReadKey();
            }
        }

        // ok
        class Kutya : Allat
        {
            public Kutya() : base(){
                this.Hang = "Én egy kutya vagyok";
                Console.ReadKey();
            }

            // Átlagos metódus felülírása (shadow hatás)
            public void hangotAd()
            {
                Console.WriteLine("Ezt a Kutya.hangotAd() metódus írta ki.");
                Console.ReadKey();
            }

            // Felül írt virtuális metódus lezárással
            public sealed override void mozog()
            {
                Console.WriteLine("Ezt a lezárt mozog() metódus írta ki.");
                Console.ReadKey();
            }
        }

        class Komondor : Kutya
        {
            public Komondor() : base(){
                this.Name = "Komondor";
            }

            public override void mozog()
            {
                Console.WriteLine("Elindultam");
            }
        }

        // Osztály lezárása
        sealed class Macska : Allat
        {
            public Macska()
            {
                this.Name = "Cicamica";
            }
        }

        /*//Lezárt osztályból nem származtatható
        class Sziami : Macska
        {

        }*/


        static void Main(string[] args)
        {
        }
    }
}
