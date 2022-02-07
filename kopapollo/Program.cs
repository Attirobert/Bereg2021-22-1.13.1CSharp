using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kopapollo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] opciok = { "ko", "papir", "ollo" };
            Random random = new Random();
            string folytatas = "igen";
            
            while(folytatas == "igen")
            {
                int pc_random = random.Next(0, 3);
                string pc_valasztas = opciok[pc_random];

                Console.WriteLine("ko, papir vagy ollo");
                string user_valasztas = Console.ReadLine();

                Console.WriteLine("pc valasztasa: {0}", pc_valasztas);

                if (pc_valasztas == "ollo" && user_valasztas == "ollo")
                {
                    Console.WriteLine("Dontetlen");
                }
                else if (pc_valasztas == "ollo" && user_valasztas == "papir")
                {
                    Console.WriteLine("PC nyert");
                }
                else if (pc_valasztas == "ollo" && user_valasztas == "ko")
                {
                    Console.WriteLine("Nyertel");
                }
                else if (pc_valasztas == "papir" && user_valasztas == "ollo")
                {
                    Console.WriteLine("Nyertel");
                }
                else if (pc_valasztas == "papir" && user_valasztas == "papir")
                {
                    Console.WriteLine("Dontetlen");
                }
                else if (pc_valasztas == "papir" && user_valasztas == "ko")
                {
                    Console.WriteLine("PC nyert");
                }
                else if (pc_valasztas == "ko" && user_valasztas == "ollo")
                {
                    Console.WriteLine("Pc nyert");
                }
                else if (pc_valasztas == "ko" && user_valasztas == "papir")
                {
                    Console.WriteLine("NYertel");
                }
                else if (pc_valasztas == "ko" && user_valasztas == "ko")
                {
                    Console.WriteLine("Dontetlen");
                }

                Console.WriteLine("Szeretned e folytatni? (igen/nem)");
                folytatas = Console.ReadLine();
            }
        }
    }
}
