using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szigetek
{
    class Program
    {
        static void Main(string[] args)
        {
            //változók
            string data = "0011111010111101101110";//5db sziget, legelső a leghoszabb:5
            bool szarazfold = (data[0].ToString() == "1")? true:false;
            
            //elsőnek 
            int sziget = 0, //szigetek száma
                szigetHossz = 0,
                szigetHosszMax = 0;
            for (int i = 1; i < data.Length; i++)
            {
                //Ha új szigethez érünk
                if (data[i].ToString() == "1" && !szarazfold)
                {
                    szarazfold = true;
                    sziget++;
                    szigetHossz = 1;
                }
                //ha sziget felett haladunk
                else if (data[i].ToString() == "1" && szarazfold)
                {
                    szigetHossz++;
                }
                //ha sziget végéhez érünk
                else if(data[i].ToString() == "0" && szarazfold)
                {
                    if(szigetHossz > szigetHosszMax)
                    {
                        szigetHosszMax = szigetHossz;
                    }
                    szarazfold = false;
                }
            }
            Console.WriteLine("A leghoszabb sziget hossza {0}, szigetek száma {1}", szigetHosszMax, sziget);
            Console.ReadKey();
        }
    }
}
