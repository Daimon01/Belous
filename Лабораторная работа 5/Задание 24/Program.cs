using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_24
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
            if ((x >= 2 && y >= 1) || (x >= 2 && y <= -1.5))
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
