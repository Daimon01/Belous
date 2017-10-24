using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, r;
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            r = x1 * x2 + x1 * x3 + x2 * x3;
            Console.WriteLine("{0:F4}", r);
        }
    }
}
