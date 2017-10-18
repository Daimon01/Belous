using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String rad;
            rad = Console.ReadLine();
            double a;
            a = double.Parse(rad);
            if(a>0)
            {
                a = 4 * Math.PI * (a * a * a) / 3;
                Console.WriteLine("{0:F4}", a);
            }
            else
            {
                Console.WriteLine("Радиус должен быть положительным");
            }
        }
    }
}
