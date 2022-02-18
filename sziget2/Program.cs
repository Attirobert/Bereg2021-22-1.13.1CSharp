using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sziget2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók deklárálsa
            string karakterlanc = "101011111000110010101111111100001110011111100001"; // 10 sziget, leghosszabb 9
            int leghosszabb = 0; // Leghosszabb sziget kezdeti értéke
            int szigethossz; // Adott sziget hossza
            int szigetszam; // Szigetek számának kezdeti értéke

            if (karakterlanc[0] == '1')
            {
                szigetszam = 1;
                szigethossz = 1;
            }
            else
            {
                szigetszam = 0;
                szigethossz = 0;
            }

            for (int i = 1; i < karakterlanc.Length; i++)
            {
                if (karakterlanc[i] == '1' && karakterlanc[i-1] == '0') // Amikor tengerről szigetre képünk
                {
                    szigetszam++;
                    szigethossz = 1;
                } else if (karakterlanc[i] == '1' && karakterlanc[i - 1] == '1') // Amikor a szigeten vagyunk
                {
                    szigethossz++;
                } else if (karakterlanc[i] == '0' && karakterlanc[i - 1] == '1') // Amikor szigetről lépünk tengerre
                {
                    if (szigethossz > leghosszabb)
                    {
                        leghosszabb = szigethossz;
                    }
                }
            }
            Console.WriteLine("A leghosszabb sziget: {0}", leghosszabb);
            Console.WriteLine("Szigetek száma: {0}", szigetszam);
            Console.ReadKey();
        }
    }
}
