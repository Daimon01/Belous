using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1, r2, res;
            Console.Write("Введите число R1: ");
            r1 = double.Parse(Console.ReadLine());
            Console.Write("Введите число R2: ");
            r2 = double.Parse(Console.ReadLine());
            if (r1 != 0)
            {
                if (r2 != 0)
                {
                    res = (1 / r1) + (1 / r2);
                    Console.WriteLine("{0:F4}", res);
                }
                else
                {
                    Console.WriteLine("Значение R2 должно быть не равно нулю");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Значение R1 не должно быть равно нулю");
                return;
            }
        }
    }
}
