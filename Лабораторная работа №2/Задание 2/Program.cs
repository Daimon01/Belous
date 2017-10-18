using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String edge;
            edge = Console.ReadLine();
            int a;
            a = int.Parse(edge);
            if (a > 0) 
            {
            a = 6 * (a*a);
                Console.WriteLine(a);
            }
             else Console.WriteLine("Значение edge должнобыть положительным!");
        }
    }
}
