using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_32
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, h1, w1, x2, y2, h2, w2;
            Console.Write("Введите координаты верхнего левого угла первого прямоугольника: ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту прямоугольника: ");
            h1 = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            w1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты верхнего левого угла второго прямоугольника: ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту прямоугольника: ");
            h2 = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            w2 = double.Parse(Console.ReadLine());
            h1 = y1 + h1;
            w1 = x1 + w1;
            h2 = y2 + h2;
            w2 = x2 + w2;
            if (h1 <= 0 || h2 <= 0)
            {
                Console.WriteLine("Высота должна быть положительна");
                return;
            }
            if ((x1 == x2 && y1 == y2) || (x1 < w2 && x1 > x2 && y1 < h2 && y1 > y2) || (x2 < w1 && x2 > x1 && y2 > y1 && y2 < h1))
            {
                if (x1 < w2 && x1 > x2 && y1 < h2 && y1 > y2 && w1 <= w2 && h1 <= h2)
                {
                    Console.WriteLine("{\"x\":" + x1 + "},\"y\":" + y1 + "},{\"w\":" + w1 + "},{\"h\":" + h1 + "}");
                    return;
                }
                if (x1 < w2 && x1 > x2 && y1 < h2 && y1 > y2 && w1 > w2 && h1 > h2)
                {
                    Console.WriteLine("{\"x\":" + x1 + "},\"y\":" + y1 + "},{\"w\":" + (w2 - x1) + "},{\"h\":" + (y1 - h2) + "}");
                    return;
                }
                if (x1 < w2 && x1 > x2 && y1 < h2 && y1 > y2 && w1 > w2 && h1 <= h2)
                {
                    Console.WriteLine("{\"x\":" + x1 + "},\"y\":" + y1 + "},{\"w\":" + (w2 - x1) + "},{\"h\":" + h1 + "}");
                    return;
                }
                if (x1 < w2 && x1 > x2 && y1 < h2 && y1 > y2 && w1 <= w2 && h1 > h2)
                {
                    Console.WriteLine("{\"x\":" + x1 + "},\"y\":" + y1 + "},{\"w\":" + w1 + "},{\"h\":" + (h2 - y1) + "}", x1, y1, w1, y1 - h2);
                    return;
                }
                if (x2 < w1 && x2 > x1 && y2 < h1 && y2 > y1 && w2 <= w1 && h2 <= h1)
                {
                    Console.WriteLine("{\"x\":" + x2 + "},\"y\":" + y2 + "},{\"w\":" + w2 + "},{\"h\":" + h2 + "}");
                    return;
                }
                if (x2 < w1 && x2 > x1 && y2 < h1 && y2 > y1 && w2 > w1 && h2 > h1)
                {
                    Console.WriteLine("{\"x\":" + x2 + "},\"y\":" + y2 + "},{\"w\":" + (w1 - x2) + "},{\"h\":" + (h1 - y2) + "}");
                    return;
                }
                if (x2 < w1 && x2 > x1 && y2 < h1 && y2 > y1 && w2 > w1 && h2 <= h1)
                {
                    Console.WriteLine("{\"x\":" + x2 + "},\"y\":" + y2 + "},{\"w\":" + (w1 - x2) + "},{\"h\":" + h2 + "}");
                    return;
                }
                if (x2 < w1 && x2 > x1 && y2 < h1 && y2 > y1 && w2 <= w1 && h2 > h1)
                {
                    Console.WriteLine("{\"x\":" + x2 + "},\"y\":" + y2 + "},{\"w\":" + w2 + "},{\"h\":" + (h1 - y2) + "}");
                    return;
                }
                if (x1 == x2 && y1 == y2 && w1 <= w2 && h1 <= h2)
                {
                    Console.WriteLine("{\"x\":" + x1 + "},\"y\":" + y1 + "},{\"w\":" + w1 + "},{\"h\":" + h1 + "}");
                    return;
                }
                if (x1 == x2 && y1 == y2 && w1 <= w2 && h1 > h2)
                {
                    Console.WriteLine("{\"x\":" + x1 + "},\"y\":" + y1 + "},{\"w\":" + w1 + "},{\"h\":" + h2 + "}");
                    return;
                }
                if (x1 == x2 && y1 == y2 && w1 > w2 && h1 <= h2)
                {
                    Console.WriteLine("{\"x\":" + x1 + "},\"y\":" + y1 + "},{\"w\":" + w2 + "},{\"h\":" + h1 + "}");
                    return;
                }
                if (x1 == x2 && y1 == y2 && w1 > w2 && h1 > h2)
                {
                    Console.WriteLine("{\"x\":" + x1 + "},\"y\":" + y1 + "},{\"w\":" + w2 + "},{\"h\":" + h2 + "}");
                    return;
                }
            }
            Console.WriteLine("Не пересекаются");
        }
    }
}
