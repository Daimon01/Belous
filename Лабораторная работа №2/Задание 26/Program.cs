using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, r;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            if (a != 0)
            {
                if (d != 0)
                {
                    r = (a * d + b * c) / (a * d);
                    Console.WriteLine("{0:F4}", r);
                    return;
                }
                Console.WriteLine("Значение d должно быть не равно нулю");
                return;
            }
            Console.WriteLine("Значение a должно быть не равно 0");
        }
    }
}
