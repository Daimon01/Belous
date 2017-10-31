using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_28
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, k, r;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());
            k = a * Math.Pow(x, 2) + b * x + c;
            if (k > 0)
            {
                if (a > 0 && b > 0 && x > 0 && c > 0)
                {
                    r = 1 / Math.Sqrt(a * Math.Pow(x, 2) + b * x + c);
                    Console.WriteLine("{0:F4}", r);
                }
                else
                {
                    Console.WriteLine("Знаменатель не должен быть равен 0");
                }
            }
            else
            {
                Console.WriteLine("Подкоренное выражение должно быть не отрицательным");
            }
        }
    }
}
