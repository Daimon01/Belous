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
            double mass1, mass2, dis, f;
            mass1 = double.Parse(Console.ReadLine());
            mass2 = double.Parse(Console.ReadLine());
            dis = double.Parse(Console.ReadLine());
            if (dis > 0)
            {
                if (mass1 > 0 && mass2 > 0)
                {
                    f = 9.8067 * ((mass1 * mass2) / Math.Pow(dis, 2));
                    Console.WriteLine("{0:F4}", f);
                    return;
                }
                else
                {
                    Console.WriteLine("Масса должна быть не отрицательной");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Дистанция должна быть не отрицательной");
                return;
            }
        }
    }
}
