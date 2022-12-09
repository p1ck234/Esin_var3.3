using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Func(10);
            Console.WriteLine(x);
            Console.ReadKey();
        }

        static int Func(int x)
        {
            if (x == 0)
            {
                return 2;
            }
            else if (x == 1)
            {
                return 3;
            }
            else if (x == 2)
            {
                return 4;
            }
            else
            {
                return Func(x - 2) + Func(x - 1) + Func(x - 3);
            }
        }
    }
}