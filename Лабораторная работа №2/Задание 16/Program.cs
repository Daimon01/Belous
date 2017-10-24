using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, r;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (y > 0)
            {
                y = Math.Sqrt(y);
                if (x<=Math.Sqrt(y))
                {
                     Console.WriteLine("Подкоренное выражение не должно быть отрицательным");
                }
                else
                {
                    r = -5 * Math.Sqrt(x + y);
                    Console.WriteLine("{0:F4}", r);
                }
            }
            else
            {
                Console.WriteLine("Значение второго числа должно быть положительным");
            }
        }
    }
}
