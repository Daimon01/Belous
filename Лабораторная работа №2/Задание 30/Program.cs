using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_30
{
    class Program
    {
        static void Main(string[] args)
        {
            double grad1, grad2, res;
            grad1 = double.Parse(Console.ReadLine());
            grad2 = double.Parse(Console.ReadLine());
            grad1 = grad1 * Math.PI / 180;
            grad2 = grad2 * Math.PI / 180;
            res = (Math.Sin(grad1) * Math.Cos(grad2)) + (Math.Cos(grad1) * Math.Sin(grad2));
            Console.WriteLine("{0:F4}", res);
        }
    }
}
