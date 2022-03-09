using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Vektor
    {
        private int[] vektor;   // Ebben tároljuk a számokat
        private int dim,    // Vektor mérete
            rndMin = 1,     // Véletlenszám alsó határa
            rndMax = 100;   // Véletlenszám felső határa

        private Random rnd = new Random();

        public Vektor() 
        {
            // Vektor létrehozása
            makeVektor();

            // Vektor feltöltése véletlen számokkal
            feltVektor(vektor);
        }

        // Vektor létrehozása
        private void makeVektor()
        {
            // Vektor méretének beolvasása
            dim = Convert.ToInt32(Console.ReadLine());

            // Vektor létrehozása
            vektor = new int[dim];
        }

        // Vektor feltöltése véletlen számokkal
        private void feltVektor(int[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = rnd.Next(rndMin, rndMax);
            }
        }

        // Összeg kiírása
        public int getOsszeg() { return this.vektor.Sum(); }

        // Átlag kiírása
        public double getAtlag() { return Math.Round(this.vektor.Average(), 2); }

        // Min kiírása
        public int getMin() { return this.vektor.Min(); }

        // Max kiírása
        public int getMax() { return this.vektor.Max(); }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Vektor v = new Vektor();
            Console.WriteLine("Az elemek összege: {0}", v.getOsszeg());
            Console.WriteLine("Az elemek átlaga: {0}", v.getAtlag());
            Console.WriteLine("A legkisebb elem: {0} és indexe: {1}, {2}", v.getMin());

        }
    }
}
