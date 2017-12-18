using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_33
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Введите длину: ");
            a = double.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("длина должна быть положительной");
            }
            if (a == 0)
            {
                return;
            }
            for (int i = 0; i < a; i++)
            {
                if (i == 0)
                {
                    Console.Write("+");
                }
                if (i == a - 1)
                {
                    Console.WriteLine("+");
                }
                if (i >= 1 && i < a - 1)
                {
                    Console.Write("-");
                }
            }
            for (int i = 0; i < a; i++)
            {
                if (i == 0)
                {
                    Console.Write("|");
                }
                if (i == a - 1)
                {
                    Console.WriteLine("|");
                }
                if (i >= 1 && i < a - 1)
                {
                    Console.Write(".");
                }
            }
            for (int i = 0; i < a; i++)
            {
                if (i == 0)
                {
                    Console.Write("+");
                }
                if (i == a - 1)
                {
                    Console.WriteLine("+");
                }
                if (i >= 1 && i < a - 1)
                {
                    Console.Write("-");
                }
            }
        }
    }
}
