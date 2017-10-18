using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String x;
            x = Console.ReadLine();
            double a;
            a = double.Parse(x);
            a = a + 7;
            Console.WriteLine("{0:F4}", a);

        }
    }
}
