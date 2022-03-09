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
        public int getOsszeg(int[] p) { return p.Sum(); }

        // Átlag kiírása
        public double getAtlag(int[] p) { return Math.Round(p.Average(), 2); }

        // Min kiírása
        public int getMin(int[] p) { return p.Min(); }

        // Min kiírása
        public int getMax(int[] p) { return p.Max(); }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Vektor v = new Vektor();
            Console.WriteLine("Az elemek összege: {0}", v.getOsszeg(v.));

        }
    }
}
