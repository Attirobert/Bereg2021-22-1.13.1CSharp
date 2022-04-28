using System;
using System.Collections.Generic;
using System.Text;

namespace Negyzet
{
    public class Square
    {
        // Tagváltozók
        public double Side { get; set; }

        // Konstruktor
        public Square(double side)
        {
            this.Side = side;
        }

        // Átmérő számítás
        public double Atmero()
        {
            return Math.Sqrt(Math.Pow(this.Side, 2) * 2);
        }

        // Kerület számítása
        public double Kerulet()
        {
            return 4 * this.Side;
        }

        // Terület számítása
        public double Terulet()
        {
            return Math.Pow(this.Side, 2);
        }

        // Oszlop térfogat számítása
        public double Oszlop(double magas)
        {
            // Ellenörzés
            if (magas <= 0)
            {
                // Dobunk egy kivételt
                throw new ArgumentException("A magasságnak 0-nál nagyobbnak kell lennie!");
            }
            return Terulet() * magas;
        }
    }
}
