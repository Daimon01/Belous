using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            if (x <= 61)
            {
                x = 3 * Math.Sqrt(61 - x);
                Console.WriteLine("{0:F4}", x);
            }
            else
            {
                Console.WriteLine("подкоренное выражение должно быть неотрецательным");
            }
        }
    }
}
