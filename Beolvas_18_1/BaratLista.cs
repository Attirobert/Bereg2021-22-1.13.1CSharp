using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Készítsen osztályt a barátok adatainak nyilvántartására
Adatok: név, születési dátum, neme, bulizási hajlam ( 0 -10 )

Metódusok:
Beolvas: Az adatok egy szöveg fájlban vannak.  Egy sorban egy barát adatai a leírás szerinti sorrendben, vesszővel elválasztva. A program kérje be a fájl nevét, olvassa be a rekordokat és helyezze el egy listában! A beolvasás addig tart, amíg el nem érjük a fájl végét, vagy egy üres sorhoz nem ér. Amikor befejezte a beolvasást, erről üzenetet küld.

Kiir: A beolvasott adatokat jelenítse meg táblázatos formában, soronként visszaírva azokat a képernyőre!
 */
namespace Beolvas_18_1
{
    internal class BaratLista
    {
        private class Barat
        {
            private string nev;
            private DateTime szuletett;
            private char neme;
            private int bulis;

            public Barat() { }
            
            public Barat(string nev, DateTime szuletett, char neme, int bulis) 
            {
                this.nev = nev;
                this.szuletett = szuletett;
                this.neme = neme;   
                this.bulis = bulis;
            }

            public void printBarat()
            {
                Console.WriteLine("{0,-20} {1,10} {2,1} {3}", nev, szuletett.ToShortDateString(), neme, bulis);
            }
        }

        private List<Barat> baratLista;     // Ebben tároljuk a barát objektumokat
        private string fajlNev;

        public BaratLista() {
            baratLista = new List<Barat>();     // Létrehozzuk a listát
        }

        public void Beolvas()
        {
            string sor;     // Egy sor beolvasására
            string[] mezok; // Sor szétbontásához

            // Fájlnév beolvasása
            Console.WriteLine("Adja meg a szövegfájl nevét elérési úttal!");
            fajlNev = Console.ReadLine();
            // Ha hiányzik a .txt kiterjesztés, kiegészítjük
            if (!fajlNev.EndsWith(".txt")) fajlNev += ".txt";
            
            // Beolvasás fájlból
            using (StreamReader sr = new StreamReader(fajlNev, Encoding.Default))
            //StreamReader sr = new StreamReader(fajlNev, Encoding.Default);
            while (sr.EndOfStream == false)
            {
                sor = sr.ReadLine();
                if (sor.Trim().Length == 0) continue;   // Ha üres a sor, akkor léptetünk
                
                mezok = sor.Split(',');     // Szétbontás

                // Hozzáadás a listához
                baratLista.Add(new Barat(
                    mezok[0],
                    DateTime.Parse(mezok[1]),
                    char.Parse(mezok[2]),
                    int.Parse(mezok[3])));  
            }
        }

        public void Kiir()
        {
            foreach (Barat p in baratLista )
            {
                p.printBarat();
            }
            Console.ReadKey();
        }
    }
}
