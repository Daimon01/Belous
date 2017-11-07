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
            Double x, y, z;
            Console.Write("дите первое число: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("дите второе число: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("дите третье число: ");
            z = double.Parse(Console.ReadLine());
            if (x != y && x!=z && y != z)
            {
                Console.WriteLine("Числа не равны друг другу");
                return;
            }
            Console.WriteLine("Среди чисел есть равные");
        }
    }
}
