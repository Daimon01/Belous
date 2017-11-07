using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("дите первое число: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("дите второе число: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("дите третье число: ");
            c = double.Parse(Console.ReadLine());
            if (a < b && b < c)
            {
                Console.WriteLine("Выполняется");
                return;
            }
            Console.WriteLine("Невыполняется");
        }
    }
}
