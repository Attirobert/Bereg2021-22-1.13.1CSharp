using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Készítsünk egy osztályt a következő paraméterekkel:
Projekt neve: ListDarab
Főbb metódusok:
setMeret: Bekéri a felhasználótól, hogy hány darab törtet akar beadni
setTort: 
    - Beolvas egy törtet, 
    - Ellenörzi, hogy törtszám-e, szükség esetén kicseréli a tizedespontot vesszőre. Tudni kell, hogy magyar területi beállítások mellett a Double.Parse a törtszámokban a tizedesvessző megjelenésére számít, és nem a tizedespontra. A bekérésben esetleg előforduló tizedespontot vesszőre tudjuk cserélni a Replace metódus hívásával.
      A tört megadható "/" jellel is, ekkor át kell alakítani tizedestörtté.
    - Bevitel közben mindig írja ki, hogy hányadik számnál tart a bevitel, és mennyi van még hátra! A program a bevitel végét jelzi a felhasználónak és ezután több bevitelt nem enged.
getTortek: Kiírja az adatokat a képernyőre a számokat egymás mellé írva, szóközzel elválasztva.
getAtlag: Kiírja a számok átlagát a képernyőre.
getOsszeg: Kiírja a számok összegét a képernyőre.
 */
namespace List16_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> szamok = new List<double>();
            Console.Write("Hany szamrol lesz szo : "); 
            int n =int.Parse(Console.ReadLine()); 
            for(int i = 0; i < n; i++)
            { 
                Console.Write("Kerem a {0}. szamot : ", i + 1); 
                string s = Console.ReadLine(); 
                double d = double.Parse(s.Replace( '.', ',' )); 
                szamok.Add(d);
            }
            
            //
            foreach(double x in szamok )
                Console . Write ( "{0} " , x ) ;
            Console . WriteLine ( ) ;
            //
            double sum = 0;
            foreach(double x in szamok )
                sum = sum+x ;
            Console . WriteLine ( "Atlag={0}" , sum / n ) ;
        }
    }
}
