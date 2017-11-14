using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x, y, z;
            Console.Write("Введите первое число: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            z = double.Parse(Console.ReadLine());
            if (x > y && x > z)
            {
                Console.WriteLine(x);
                return;
            }
            if (y > x && y > z)
            {
                Console.WriteLine(y);
                return;
            }
            if (z > y && z > x)
            {
                Console.WriteLine(z);
                return;
            }
        }
    }
}
