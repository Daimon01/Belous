using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_34
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Введите длину: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту: ");
            b = double.Parse(Console.ReadLine());
            if (a == 0 || b == 0)
            {
                return;
            }
            if (a < 0 || b < 0)
            {
                Console.WriteLine("Значения должны быть положительными");
                return;
            }
            for (int i = 0; i < a; i++)
            {
                if (i == 0)
                {
                    Console.Write(" 0");
                }
                else
                {
                    Console.Write(i);
                }
            }
            Console.Write("\n");
            for (int i = 0; i < b; i++)
            {
                for (int k = 0; k < a + 1; k++)
                {
                    if (k == 0)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine("|");
            }
            for (int i = 0; i < a; i++)
            {
                if (i == 0)
                {
                    Console.Write(" _");
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
