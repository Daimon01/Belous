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
            double rad, edge;
            Console.Write("Введите радиус круга: ");
            rad = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны квадрата: ");
            edge = double.Parse(Console.ReadLine());
            if (rad > 0)
            {
                if (edge > 0)
                {
                    rad = Math.PI * Math.Pow(rad, 2);
                    edge = Math.Pow(edge, 2);
                    if (rad > edge)
                    {
                        Console.WriteLine("Площадь круга {0:F4} больше площади квадрата {1:F4}", rad, edge);
                    }
                    else
                    {
                        Console.WriteLine("Площадь квадрата {0:F4} больше площади круга {1:F4}", edge, rad);
                    }
                }
                else
                {
                    Console.WriteLine("Длина должна быть положительной");
                }
            }
            else
            {
                Console.WriteLine("Радиус должен быть положительным");
            }
        }
    }
}
