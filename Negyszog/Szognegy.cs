using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negyszog
{
    public class Szognegy
    {
        // Tagváltozó (property)
        public double Side { get; set; }
        public double oszlop;

        // Konstruktor
        public Szognegy(double side)
        {
            this.Side = side;
        }

        // Kerület
        public double Kerulet()
        {
            return 4 * this.Side;
        }

        // Terület
        public double Terulet()
        {
            return Math.Pow(Side, 2);
        }

        // Átló
        public double Atlo()
        {
            return Math.Sqrt(2 * Math.Pow(Side, 2));
        }

        // Oszlop méretének beolvasása
        public void setOszlop(double magas)
        {
            // Az oszlop nem lehet negatív
            if (magas <= 0)
            {
                throw new ArgumentException("A magasság nem lehet 0 vagy negatív");
            }
            else this.oszlop = magas;
        }
    }
}
