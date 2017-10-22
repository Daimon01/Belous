using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            double a;
            a = double.Parse(x);
            a = a * Math.PI /180 ;
            a = Math.Sin(a);
            Console.WriteLine("{0:F4}", a);
        }
    }
}
