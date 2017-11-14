using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_25
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
            if ((x >= 1 && x <= 3) && (y <= -1 && y >= -2))
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
