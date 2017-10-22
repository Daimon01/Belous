using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string grad;
            grad = Console.ReadLine();
            double a;
            a = double.Parse(grad);
            a = a * Math.PI / 180;
            Console.WriteLine("{0:F4}", a);
        }
    }
}
