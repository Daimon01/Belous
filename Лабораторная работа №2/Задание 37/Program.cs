using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_37
{
    class Program
    {
        static void Main(string[] args)
        {
            double vol, vol1, vol2, tem, tem1, tem2;
            vol1 = double.Parse(Console.ReadLine());
            tem1 = double.Parse(Console.ReadLine());
            vol2 = double.Parse(Console.ReadLine());
            tem2 = double.Parse(Console.ReadLine());
            if (vol1 > 0 && vol2 > 0)
            {
                vol = vol1 + vol2;
                tem = (tem1 * vol1 + tem2 * vol2) / (vol1 + vol2);
                Console.WriteLine("Объем {0:F0} температура {1:F4}", vol, tem);
            }
            else
            {
                Console.WriteLine("Объем должен быть положительный");
            }
        }
    }
}
