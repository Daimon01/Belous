using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double sp1, sp2, dis, time;
            sp1 = double.Parse(Console.ReadLine());
            sp2 = double.Parse(Console.ReadLine());
            dis = double.Parse(Console.ReadLine());
            if (sp1 >= 0 && sp2 >= 0 && dis >= 0)
            {
                time = dis / (sp1 + sp2);
                Console.WriteLine("{0:F4}", time);
            }
            else
            {
                Console.WriteLine("Скорость или расстояние не должны быть отрицательными");
                return;
            }
        }
    }
}
