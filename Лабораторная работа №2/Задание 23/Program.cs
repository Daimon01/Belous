using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, dis;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            if (a > 0)
            {
                dis = Math.Pow(b, 2) - 4 * a * c;
                Console.WriteLine("{0:F4}", dis);
            }
            else
            {
                Console.WriteLine("Данное уровнение не является квадратным");
                return;
            }
        }
    }
}
