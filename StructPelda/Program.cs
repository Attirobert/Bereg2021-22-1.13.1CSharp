using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPelda
{
    class Program
    {
        struct Point
        {
            int x;
            public int X
            {
                get { return x; }
                set { x = value; }
            }
            int y;
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        struct Line
        {
            Point a;
            public Point A
            {
                get { return a; }
                set { a = value; }
            }
            Point b;
            public Point B
            {
                get { return b; }
                set { b = value; }
            }
        }
        static void Main(string[] args)
        {
            Line l = new Line();
            l.A = new Point(10, 10);
            l.B = new Point(20, 20);
            //l.A.X = 5;
            Console.WriteLine("Pont koordináták A: {0},{1}; B: {2},{3}", l.A.X, l.A.Y, l.B.X, l.B.Y);
            Console.ReadKey();
        }
    }
}
