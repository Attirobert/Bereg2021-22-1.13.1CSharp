using Beolvas_18_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapoz_18_2
{
    class LapozLista : BaratLista
    {

        // Lapozó metódus
        public void Lapoz()
        {
            const int N = 5; 
            const int M = 4; 
            int[,] m = new int[N, M]; 
            
            for(int k = 0; k < N; k++)
                { 
                for(int l = 0; l < M; l++)
                    Console.Write(" {0 ,5} ", m[k, l]); 

                Console.WriteLine(); 
            }
            
            int i = 0 ,  j = 0; 
            bool folyt = true; 
            while (folyt )
                {
                // m[i, j]  cella kiemelese
                 Console.SetCursorPosition(j * 7, i);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("␣ {0 ,5} ␣", m[i, j]);
                Console.BackgroundColor = ConsoleColor.Black;

                ConsoleKeyInfo k = Console.ReadKey();
                // m[i, j]  cella kiemeles  megszuntetese
                 Console.SetCursorPosition(j * 7, i);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" {0 ,5} ", m[i, j]);
                //  . .
                switch (k.Key)
                {
                 case ConsoleKey.UpArrow :
                     if(i > 0)  i--;
                    break;
                case ConsoleKey.DownArrow :
                     if(i<N-1)  i++;
                    break;
                case ConsoleKey.LeftArrow :
                     if(j > 0)  j--;
                    break;
                case ConsoleKey.RightArrow :
                     if(j<M-1)  j++;
                    break;
                case ConsoleKey.Escape :
                     folyt = false;
                    break;
                case ConsoleKey.Enter :
                     // m[i, j]  bekerese
                     // . . .
                     break;
            }
        }
    }
    }
}
