using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_39
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            Console.Write("Введите первое число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int i;
                i = a;
                a = b;
                b = i;
            }
            for (int i = a; i <= b; i++)
            {
                if (i < ((b - a) / 2) + a)
                {
                    Console.Write(i + "<");
                }
                if (i >= ((b - a) / 2) + a && i != b)
                {
                    Console.Write(i + ">");
                }
                if (i == b)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
