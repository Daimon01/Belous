using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            if (a >= -100 && a <= 500)
            {

                while (a <= 500)
                {
                    b = a + b;
                    Console.Write(b + " ");
                    a++;
                }
                Console.WriteLine("\nОтвет: " + b);
            }
            else
            {
                Console.WriteLine("Значение А должно быть в интервале от -100 до 500!");
            }
        }
    }
}
