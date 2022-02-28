using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Allat
    {
        // Osztályváltozók (properties)
        private string nev;
        private string fajta;
        private string szin;
        private int kor;

        public Allat(string nev, string fajta, string szin)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
        }

        public string getNev()
        {
            return this.nev;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Példányosítunk objektumokat
            Allat allat1 = new Allat("Bodri", "Puli", "fekete");
            Console.WriteLine("Az állat1 neve: {0}", allat1.getNev()); 
            
            Allat allat2 = new Allat("Bolhás", "Komondor", "fehér");
            Console.WriteLine("Az állat2 neve: {0}", allat2.getNev());
            Console.ReadKey();
        }
    }
}
