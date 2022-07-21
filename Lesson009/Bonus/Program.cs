using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;

            void ChangeValues(int a, int b)
            {
                a = x;
                b = y;

                x = x + y;
                y = x - y;
                x = x - y;
            }

            ChangeValues(x, y);

            Console.WriteLine(x);
            Console.WriteLine(y);

        }
    }
}
