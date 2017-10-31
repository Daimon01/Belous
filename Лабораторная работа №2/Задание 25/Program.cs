using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_25
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, grad, res;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            grad = double.Parse(Console.ReadLine());
            res = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(grad * Math.PI / 180));
            Console.WriteLine("{0:F4}", res);
        }
    }
}
