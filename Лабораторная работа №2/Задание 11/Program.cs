using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            double a;
            a = double.Parse(x);
            if (a >= 0)
            {
                a = Math.Sqrt(a);
                Console.WriteLine("{0:F4}", a);
            }
            else
            {
                Console.WriteLine("Значение Х должнобыть положительным");
            }
        }
    }
}
