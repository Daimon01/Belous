using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_33
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = double.Parse(Console.ReadLine());
            if (a > 0)
            {
                a = Math.Sqrt(Math.Pow((6350 + a), 2) - Math.Pow(6350, 2));
                Console.WriteLine("{0:F4}", a);
            }
            else
            {
                Console.WriteLine("Высота над уровнем Земли должна быть неотрицательна");
            }
        }
    }
}
