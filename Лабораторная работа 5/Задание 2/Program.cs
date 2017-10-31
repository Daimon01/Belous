using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q;
            Console.Write("Введите первое число: ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            q = int.Parse(Console.ReadLine());
            if (p > q)
            {
                Console.WriteLine("Максимальное " + p + " минимальное " + q);
            }
            else
            {
                Console.WriteLine("Максимальное " + q + " минимальное " + p);
            }
        }
    }
}
