using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            String total, part;
            total = Console.ReadLine();
            part = Console.ReadLine();
            double sht, ost, a, b;
            sht = 0;
            ost = 0;
            a = double.Parse(total);
            b = double.Parse(part);
            if (a > 0)
            {
                if(b>0)
                {
                    b = b / 100;
                    sht = a / b;
                    ost = a % b;
                    ost = ost * 100;
                    Console.WriteLine("{0:F0} шт и {1:F0} см", sht, ost);
                }
                else
                {
                    Console.WriteLine("Значение partInCm должнобыть положительным");
                }
            }
            else
            {
                Console.WriteLine("Значение totalInM должно быть положительным");
            }
        }
    }
}
