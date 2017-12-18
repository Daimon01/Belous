using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_36
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c = 0;
            Console.Write("Введите первое число: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                double i;
                i = a;
                a = b;
                b = i;
            }
            for (double i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    for (double h = 0; h < c; h++)
                    {
                        Console.Write(".");
                    }
                    Console.Write(i+"\n");
                    c++;
                }
            }
        }
    }
}
