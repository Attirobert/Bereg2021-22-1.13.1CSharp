using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    public class Hengerclass
    {
        private double sugar, magas;

        public Hengerclass() { }

        public void setSugar()
        {
            Console.WriteLine("Adja meg a henger sugarát:");
            sugar = Convert.ToDouble(Console.ReadLine());
        }

        public double getSugar()
        {
            return sugar;
        }

        public void setMagas()
        {
            Console.WriteLine("Adja meg a henger magasságát:");
            magas = Convert.ToDouble(Console.ReadLine());
        }

        public double getTerulet()
        {
            return Math.Round(Math.Pow(sugar, 2) * Math.PI, 2);
        }

        public double getKerulet()
        {
            return Math.Round(2*sugar * Math.PI, 2);
        }

        public double getFelszin()
        {
            return Math.Round(2*getTerulet() + getKerulet()*magas, 2);
        }

        public double getTerfogat()
        {
            return Math.Round(getTerulet() * magas, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
