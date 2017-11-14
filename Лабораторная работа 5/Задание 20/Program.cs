using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
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
            if (y <= 1.5 && y >= -2)
            {
                Console.WriteLine("Точка с координатами (x, y) принадлежит множеству");
            }
            else
            {
                Console.WriteLine("Точка с координатами (x, y) не принадлежит множеству");
            }
        }
    }
}
