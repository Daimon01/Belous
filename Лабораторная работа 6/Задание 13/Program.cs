using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sum = 0, b;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                while (b <= a)
                {
                    sum = sum + b;
                    Console.Write(sum + " ");
                    b++;

                }
                Console.WriteLine("\nОтвет: " + sum);
            }
            else
            {
                while (a <= b)
                {
                    sum = sum + a;
                    Console.Write(sum + " ");
                    a++;

                }
                Console.WriteLine("\nОтвет: " + sum);
            }
        }
    }
}
