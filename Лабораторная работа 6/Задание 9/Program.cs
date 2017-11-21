using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;
            while (a <= 9)
            {
                b = a * 7;
                Console.WriteLine(a + " x 7 = " + b);
                a++;
            }
        }
    }
}
