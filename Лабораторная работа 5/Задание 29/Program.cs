using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x, y;
            Console.Write("Введите координату x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y: ");
            y = double.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Коорлината Х должна быть положительной");
                return;
            }
            if (y < 0)
            {
                Console.WriteLine("Координата У должнабыть положительной");
                return;
            }
            if ((x >= 100 && x <= 170) && (y >= 100 && y <= 190))
            {
                Console.WriteLine("Точка внутри прямоугольника");
                return;
            }
            Console.WriteLine("Точка снаружи прямоугольника");

        }
    }
}
