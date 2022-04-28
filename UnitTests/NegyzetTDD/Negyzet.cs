using System;
using System.Collections.Generic;
using System.Text;

namespace NegyzetTDD
{
    public class Negyzet
    {
        // Tagváltozók
        public double Side { get; set; }

        // Konstruktor
        public Negyzet(double side)
        {
            this.Side = side;
        }

        // Átmérő
        public double Atmero()
        {

            return Side*Math.Sqrt(2);
        }

        public double Kerulet()
        {
            return 4*Side;
        }

        public double Terulet()
        {
            return Side*Side;
        }

        public double Oszlop(double m)
        {
            if (m <= 0)
            {
                throw new ArgumentException("Helytelen érték!");
            }
            return Terulet()*m;
        }
    }
}
