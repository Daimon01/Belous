using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_29
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, r;
            x = double.Parse(Console.ReadLine());
            if (x + 5 > 0 && x - 5 >= 0 && x > 0)
            {
                r = (Math.Sqrt(x + 5) + Math.Sqrt(x - 5)) / (2 * Math.Sqrt(x));
                Console.WriteLine("{0:F6}", r);
            }
            else
            {
                Console.WriteLine("Подкоренное выражение должно быть не отрицательным");
            }
        }
    }
}
