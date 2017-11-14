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
            Double a, b, c;
            Console.Write("Введите длину стороны А: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны В: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны С: ");
            c = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Сторона А должна быть положительной");
                return;
            }
            if (b <= 0)
            {
                Console.WriteLine("Сторона B должна быть положительной");
                return;
            }
            if (c <= 0)
            {
                Console.WriteLine("Сторона C должна быть положительной");
                return;
            }
            if (a == b || b == c || a == c)
            {
                Console.WriteLine("Треугольник является равнобедренным");
            }
            else
            {
                Console.WriteLine("Треугольник не является равноберенным");
            }
        }
    }
}
