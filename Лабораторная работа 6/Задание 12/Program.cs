using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i = -10, sum = 0;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            if (a >= -10 && a <= 10000)
            {

                while (i <= a)
                {
                    sum = sum + i;
                    Console.Write(sum + " ");
                    i++;
                    
                }
                Console.WriteLine("\nОтвет: " + sum);
            }
            else
            {
                Console.WriteLine("Значение А должно быть в интервале от -10 до 10000!");
            }
        }
    }
}
