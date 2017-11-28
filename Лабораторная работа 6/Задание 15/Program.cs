using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 20, b = 0;
            while (a <= 40)
            {
                b = Math.Pow(a, 3) + b;
                Console.Write(b + " ");
                a++;
            }
            Console.WriteLine("\nОтвет: " + b);
        }
    }
}
