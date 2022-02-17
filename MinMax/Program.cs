using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók 
            int tomb = 100, // Tömb mérete
                min = int.MaxValue, // Legkisebb elem változója
                max = int.MinValue, // Legnagyobb elem változója
                minIdx = 0, // Legkisebb elem indexe
                maxIdx = 0, // Legnagyobb elem indexe

                // Véletlenszám határai
                alsoHatar = 0,  
                felsoHatar = 1000;

            int[] array = new int[tomb];
            Random rnd = new Random();

            // Tömb feltöltése
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(alsoHatar, felsoHatar);
            }

            // Min Max keresés
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIdx = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    maxIdx = i;
                }
            }

            // Eredmény kiíratása
            Console.WriteLine("A tömb legkisebb eleme: {0}, az indexe: {1}", min, minIdx);
            Console.WriteLine("A tömb legnagyobb eleme: {0}, az indexe: {1}", max, maxIdx);
            Console.ReadKey();
        }
    }
}
