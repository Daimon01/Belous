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
            double t1, t2, x1, x2, y1, y2;
            Console.Write("Введите первую координату точки: ");
            t1 = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую координату точки: ");
            t2 = double.Parse(Console.ReadLine());
            Console.Write("Введите первую координату первой точки прямой: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую координату первой точки прямой: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите первую координату второй точки прямой: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую координату второй точки прямой: ");
            y2 = double.Parse(Console.ReadLine());
            if (t1 < 0 || t2 < 0 || x1 < 0 || x2 < 0 || y1 < 0 || y2 < 0)
            {
                Console.WriteLine("Координаты должны быть не отрицательными!");
                return;
            }
            if((t1-x1)*(y2-y1)-(x2-x1)*(t2-y1) == 0)
            {
                Console.WriteLine("точка принадлежит прямой");
                return;
            }
            Console.WriteLine("Точка не пренадлежит прямой");
        }
    }
}
