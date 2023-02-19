using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók deklarálása
            int honapokszama = 12;
            int napokszama = 30;
            int alsoHom = -10;
            int felsoHom = 30;
            int[,] homersekletmatrix = new int[honapokszama, napokszama];
            Random rnd = new Random();

            for (int i = 0; i < honapokszama; i++) // Mátrix feltöltése
            {
                for (int j = 0; j < napokszama; j++)
                {
                    homersekletmatrix[i, j] = rnd.Next(alsoHom, felsoHom);
                }
            }

            alsoHom = 0;
            felsoHom= 0;
            for (int i = 0; i < honapokszama; i++)
            {
                for (int j = 0; j < napokszama; j++)
                {
                    if (homersekletmatrix[i, j] < alsoHom) alsoHom = homersekletmatrix[i, j]; // Leghidegebb nap keresése
                    else if (homersekletmatrix[i, j] > felsoHom) felsoHom = homersekletmatrix[i, j]; // Legmelegebb és leghidegebb nap keresése
                }
            }

            Console.WriteLine("Az év legalacsonyabb hőmérséklete {0} Celsius fok volt", alsoHom);
            Console.WriteLine("Az év legmagasabb hőmérséklete {0} Celsius fok volt", felsoHom);
            Console.ReadKey();
        }
    }
}
