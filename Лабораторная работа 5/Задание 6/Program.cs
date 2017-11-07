using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double kmh, ms, a;
            Console.Write("Введите скорость в километрах в час: ");
            kmh = double.Parse(Console.ReadLine());
            Console.Write("Введите скорость в метрах в секунду: ");
            ms = double.Parse(Console.ReadLine());
            if (kmh > 0)
            {
                if (ms > 0)
                {
                    a = ms / 1000 * 3600;
                    if (kmh > a)
                    {
                        Console.WriteLine("Скорость {0:F2} м/с меньше чем {1:F2} км/ч", ms, kmh);
                    }
                    else
                    {
                        Console.WriteLine("Скорость {0:F2} км/ч меньше чем {1:F2} м/с", kmh, ms);
                    }
                }
                else
                {
                    Console.WriteLine("Скорость м/с должна быть положительной");
                }
            }
            else
            {
                Console.WriteLine("Скорость км/ч должна быть положительной");
            }
        }
    }
}
