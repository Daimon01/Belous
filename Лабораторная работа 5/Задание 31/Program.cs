using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_31
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, b1, a2, b2;
            Console.Write("Введите первый интервал чисел: ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второй интервал чисел: ");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            if (a1 > b1 || a2 > b2)
            {
                Console.WriteLine("первой значение интервала не можеьт быть больше второго");
                return;
            }
            if (a1 >= a2 && a1 <= b2)
            {
                if (b1 < b2)
                {
                    Console.WriteLine("Пересекаются ({0:F0};{1:F0})", a1, b1);
                }
                else
                {
                    Console.WriteLine("Пересекаются ({0:F0};{1:F0})", a1, b2);
                }
            }
            if (a2 >= a1 && a2 <= b1)
            {
                if (b2 < b1)
                {
                    Console.WriteLine("Пересекаются ({0:F0};{1:F0})", a2, b2);
                }
                else
                {
                    Console.WriteLine("Пересекаются ({0:F0};{1:F0})", a2, b1);
                }
            }
            else
            {
                Console.WriteLine("не пересекаются");
            }
        }
    }
}
