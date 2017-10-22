using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            double b;
            b = double.Parse(a);
            b = b % 360;
            Console.WriteLine(b);
        }
    }
}
