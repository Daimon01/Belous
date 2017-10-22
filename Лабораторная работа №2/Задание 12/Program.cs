using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            y = Console.ReadLine();
            double a;
            a = double.Parse(y);
            a = a * Math.PI / 180;
           
                a = Math.Cos(a)*5;

            Console.WriteLine("{0:F4}", a);
            }
    }
}
