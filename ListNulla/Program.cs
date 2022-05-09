using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Készítsünk egy osztályt a következő paraméterekkel:
Projekt neve: ListNulla
Főbb metódusok:
setTort: 
    - Beolvas egy törtet, 
    - Ellenörzi, hogy törtszám-e, szükség esetén kicseréli a tizedespontot vesszőre. Tudni kell, hogy magyar területi beállítások mellett a Double.Parse a törtszámokban a tizedesvessző megjelenésére számít, és nem a tizedespontra. A bekérésben esetleg előforduló tizedespontot vesszőre tudjuk cserélni a Replace metódus hívásával.
      A tört megadható "/" jellel is, ekkor át kell alakítani tizedestörtté.
    - Bevitel közben mindig írja ki, hogy hányadik számnál tart a bevitel! 
    - A bevitel akkor fejeződik be, amikor a felhasználó nullát vagy üres stringet küld be, ezután több bevitelt nem enged.
getTortek: Kiírja az adatokat a képernyőre a számokat egymás mellé írva, szóközzel elválasztva.
getAtlag: Kiírja a számok átlagát a képernyőre.
getOsszeg: Kiírja a számok összegét a képernyőre.
 */

namespace ListNulla
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
