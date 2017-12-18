using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_41
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string c, d;
            Console.Write("Введите ширину: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите первый символ: ");
            c = Console.ReadLine();
            Console.Write("Введите второй символ: ");
            d = Console.ReadLine();
            if (a < 0 || b < 0)
            {
                Console.WriteLine("Значения должны быть положительными");
                return;
            }
            if (b == 0 || a == 0)
            {
                return;
            }
            for (int i = 0; i < b; i++)
            {
                for (int k = 1; k <= a; k++)
                {
                    if (k % 2 == 0)
                    {
                        Console.Write(c);
                    }
                    if (k % 2 != 0)
                    {
                            Console.Write(d);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
