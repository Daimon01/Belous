using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b = 1;
            Console.Write("Введите число: ");
            a = double.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Значение не должно быть отрицательным");
            }
            for (int i = 0; i < a; i++)
            {
                if (b < 20)
                {
                    Console.Write("#");
                    b++;
                }
                else
                {
                    Console.Write("#\n");
                    b = 1;
                }
            }
            Console.WriteLine("\n");
        }
    }
}
