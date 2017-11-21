using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, d;
            Console.Write("Введите координату a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите координату b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите координату c: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Введите координату d: ");
            d = double.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Значение А должно быть положительным");
                return;
            }
            if (b < 0)
            {
                Console.WriteLine("Значение B должно быть положительным");
                return;
            }
            if (c < 0)
            {
                Console.WriteLine("Значение C должно быть положительным");
                return;
            }
            if (d < 0)
            {
                Console.WriteLine("Значение D должно быть положительным");
                return;
            }
            if ((a < c && b < d) || (a < d && b < c))
            {
                Console.WriteLine("Размещение возможно");
                return;
            }
            Console.WriteLine("Размещение не возможно");
        }
    }
}
