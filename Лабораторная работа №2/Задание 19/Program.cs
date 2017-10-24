using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double sp, time, acc, dis;
            sp = double.Parse(Console.ReadLine());
            time = double.Parse(Console.ReadLine());
            acc = double.Parse(Console.ReadLine());
            if (sp >= 0)
            {
                if (time > 0)
                {
                    dis = (sp * time) + ((acc * Math.Pow(time, 2)) / 2);
                    Console.WriteLine("{0:F2}", dis);
                }
                else
                {
                    Console.WriteLine("Второе значение должно быть положительным");
                    return;
                }
            }
            else
            {
                Console.WriteLine("первое значение должно быть положительным");
                return;
            }
        }
    }
}
