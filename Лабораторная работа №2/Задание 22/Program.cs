using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double f, mass, grad;
            mass = double.Parse(Console.ReadLine());
            grad = double.Parse(Console.ReadLine());
            if (mass > 0)
            {
                f = mass * 9.8067 * Math.Cos(grad * Math.PI / 180);
                Console.WriteLine("{0:F6}", f);
            }
            else
            {
                Console.WriteLine("Масса должна быть положительной");
                return;
            }
        }
    }
}
