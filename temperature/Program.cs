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

            int homerseklet;

            for (int i = 0; i < honapokszama; i++) // Mátrix feltöltése
            {
                for (int j = 0; j < napokszama; j++)
                {
                    homersekletmatrix[i, j] = rnd.Next(alsoHom, felsoHom);
                }
            }

            for (int i = 0; i < honapokszama; i++)
            {
                //if () // Legmelegebb és leghidegebb nap keresése
                //{

                //}
            }

        }
    }
}
