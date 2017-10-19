using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String c, h;
            c = Console.ReadLine();
            h = Console.ReadLine();
            double a, b;
            a = double.Parse(c);
            b = double.Parse(h);
            if (a > 0&&b > 0)
            {
                a = a * b / 2;
                Console.WriteLine("")
            }
        }
    }
}
