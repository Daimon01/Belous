using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, res;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (b <= 0)
            {
                res = a * Math.Sqrt(-7 * b);
                Console.WriteLine("{0:F4}", res);
            }
            else
            {
                Console.WriteLine("Второе значение не должно быть не положительным");
            }
        }
    }
}
