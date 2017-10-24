using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass, sp, he, kie, poe;
            Console.Write("Введите значение Mass: ");
            mass = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Velocity: ");
            sp = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Height: ");
            he = double.Parse(Console.ReadLine());
            if (mass > 0)
            {
                if (sp > 0)
                {
                    if (he > 0)
                    {
                        kie = mass * Math.Pow(sp, 2) / 2;
                        poe = mass * 9.8067 * he;
                        Console.WriteLine("Кинетическая энергия составляет: {0:F4} дж\n" +
                            "Потенциальная энергия составляет: {1:F4} дж", kie, poe);
                    }
                    else
                    {
                        Console.WriteLine("Значение height не должно быть отрицательным");
                    }
                }
                else
                {
                    Console.WriteLine("Значение Velocity должно быть положительным");

                }
            }
            else
            {
                Console.WriteLine("Значение Mass должно быть положительным");
            }
        }
    }
}
