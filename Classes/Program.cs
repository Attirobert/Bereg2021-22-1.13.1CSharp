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

        public Allat()
        {
            this.nev = "anonim";
            this.fajta = "ismeretlen";
            this.szin = "fekete";
            this.kor = 0;
        }

        public void setNev(string p)
        {
            this.nev = p;
        }

        public string getNev()
        {
            return this.nev;
        }

        public int getKor()
        {
            return this.kor;
        }

        public void setKor(int p)
        {
            if (p > 0 && p < 50)
            {
                this.kor = p;
            }
        }

        public void setFajta(string p)
        {
            this.fajta = p;
        }

        public string getFajta()
        {
            return this.fajta;
        }


        public void setSzin(string p)
        {
            this.szin = p;
        }

        public string getSzin()
        {
            return this.szin;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Példányosítunk objektumokat
            Allat allat1 = new Allat("Bodri", "Puli", "fekete");
            allat1.setKor(2);
            Console.WriteLine("Az állat1 neve: {0}, kora {1} év", allat1.getNev(), allat1.getKor()); 
            
            Allat allat2 = new Allat("Bolhás", "Komondor", "fehér");
            Console.WriteLine("\nAz állat2 neve: {0}", allat2.getNev());

            Allat allat3 = new Allat();
            allat3.setNev("Vadász");
            allat3.setFajta("Agár");
            allat3.setSzin("barna");
            allat3.setKor(5);
            Console.WriteLine("\nAz állat1 neve: {0}, kora {1} év", allat1.getNev(), allat1.getKor());


            Console.ReadKey();
        }
    }
}
