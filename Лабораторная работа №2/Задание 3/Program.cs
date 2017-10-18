using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String edge;
            edge = Console.ReadLine();
            double a;
            a = double.Parse(edge);
            if (a > 0)
            {
                a = a * a * a;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("значение должно быть положительным");
            }

        }
    }
}
