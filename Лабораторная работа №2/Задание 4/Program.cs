using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String rad;
            rad = Console.ReadLine();
            double a;
            a = double.Parse(rad);
            if (a > 0)
            {
                a = 2 * Math.PI * a;
                Console.WriteLine("{0:F4}",a);
            }
            else { Console.WriteLine("Значение должно быть положительным");
            }

        }
    }
}
