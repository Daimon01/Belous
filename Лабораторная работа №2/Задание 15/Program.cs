using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Double.Parse(Console.ReadLine());
            if (a > -273.16) 
            {
                a = a*1.8 + 32.0;
                Console.WriteLine("{0:F4}", a);
            }
            else 
            {
                Console.WriteLine("Температура должна быть выше абсолютного нуля!");

            }
        }
    }
}
