using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, g;
            for (int v = -19; v < 3; v++)
            {
                x += v;
                y++;
            }
            g = x / y;
            Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}
