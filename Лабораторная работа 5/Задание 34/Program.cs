using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_34
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, h, c, d, o;
            Console.Write("Введите ширину стола: ");
            w = int.Parse(Console.ReadLine());
            Console.Write("Ввудите высоту стола: ");
            h = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину картонки: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту картонки: ");
            d = int.Parse(Console.ReadLine());
            if (w <= 0 || h <= 0 || c <= 0 || d <= 0)
            {
                Console.WriteLine("Значения должны быть положительными");
                return;
            }
            c = w / c;
            d = h / d;
            o = c * d;
            Console.WriteLine(o + " при С вдоль W");
        }
    }
}
