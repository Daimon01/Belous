using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_30
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Введите число: ");
            a = double.Parse(Console.ReadLine());
            if (a < 0 || a > 20)
            {
                Console.WriteLine("Значение должно быть от 0 до 20");
                return;
            }
            for (int i = 1; i <= a; i++)
            {
                Console.Write("a");
            }
            Console.Write("\n");
            for (int i = 1; i <= a; i++)
            {
                Console.Write("b");
            }
            Console.Write("\n");
            for (int i = 1; i <= a; i++)
            {
                Console.Write("c");
            }
            Console.Write("\n");
            for (int i = 1; i <= a; i++)
            {
                Console.Write("d");
            }
            Console.Write("\n");
            for (int i = 1; i <= a; i++)
            {
                Console.Write("e");
            }
            Console.Write("\n");
            for (int i = 1; i <= a; i++)
            {
                Console.Write("f");
            }
            Console.Write("\n");
            for (int i = 1; i <= a; i++)
            {
                Console.Write("g");
            }
            Console.Write("\n");
            for (int i = 1; i <= a; i++)
            {
                Console.Write("h");
            }
            Console.Write("\n");
        }
    }
}
