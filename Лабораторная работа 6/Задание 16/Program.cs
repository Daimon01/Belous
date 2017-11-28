using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, sum = 0, b = 1;
            Console.Write("Введите число: ");
            a = double.Parse(Console.ReadLine());
            if (a > 0)
            {
                while (b <= a)
                {
                    sum = sum + 1 / b;
                    b++;

                }
                Console.WriteLine("\nОтвет: {0:F4} ", sum);
            }
            else
            {
                Console.WriteLine("Значение должно быть положительным");
            }
        }
    }
}
