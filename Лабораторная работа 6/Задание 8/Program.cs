using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;
            while (a <= 20)
            {
                b = a * 453;
                Console.WriteLine(a + "\t" + b);
                a++;
            }
        }
    }
}
