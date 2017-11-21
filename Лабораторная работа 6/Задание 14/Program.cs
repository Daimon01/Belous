using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            long a, sum = 1, b;
            Console.Write("Введите число: ");
            a = long.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            b = long.Parse(Console.ReadLine());
            if (a > b)
            {
                while (b <= a)
                {
                    sum = sum * b;
                    Console.Write(sum + " ");
                    b++;

                }
                Console.WriteLine("\nОтвет: " + sum);
            }
            else
            {
                while (a <= b)
                {
                    sum = sum * a;
                    Console.Write(sum + " ");
                    a++;

                }
                Console.WriteLine("\nОтвет: " + sum);
            }
        }
    }
}