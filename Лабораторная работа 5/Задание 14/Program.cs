using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
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
            if (x > -3 && x < 5)
            {
                Console.Write(x+" ");
            }
            if (y > -3 && y < 5)
            {
                Console.Write(y + " ");
            }
            if (z > -3 && z < 5)
            {
                Console.Write(z + " ");
            }
        }
    }
}
