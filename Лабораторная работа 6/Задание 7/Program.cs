using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Введите первое число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                while (a >= b)
                {
                    Console.WriteLine(a);
                    a--;
                }
            }
            else
            {
                while (b >= a)
                {
                    Console.WriteLine(a);
                    a++;
                }
            }
        }
    }
}
